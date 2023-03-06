﻿// Copyright (c) 2023 Paytools Foundation.
//
// Licensed under the Apache License, Version 2.0 (the "License") ~
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Paytools.Common.Model;
using Paytools.IncomeTax;
using Paytools.NationalInsurance;
using Paytools.Payroll.Model;
using Paytools.Pensions;
using Paytools.Pensions.Model;
using Paytools.StudentLoans;

namespace Paytools.Payroll.Payruns;

/// <summary>
/// Represents the calculator that can process an employee's set of input payroll data and
/// provide the results of the calculations in the form of an <see cref="IEmployeePayrunResult"/>.
/// </summary>
public class PayrunEntryProcessor : IPayrunEntryProcessor
{
    internal readonly struct EarningsTotals
    {
        public decimal GrossPay { get; init; }

        public decimal WorkingGrossPay { get; init; }

        public decimal TaxablePay { get; init; }

        public decimal NicablePay { get; init; }

        public decimal PensionablePay { get; init; }

        public decimal BenefitsInKind { get; init; }
    }

    private readonly Dictionary<CountriesForTaxPurposes, ITaxCalculator> _incomeTaxCalculators;
    private readonly INiCalculator _niCalculator;
    private readonly IPensionContributionCalculatorFactory _pensionCalculatorFactory;
    private readonly IStudentLoanCalculator _studentLoanCalculator;
    private readonly Dictionary<(EarningsBasis, PensionTaxTreatment), IPensionContributionCalculator> _pensionCalculators;

    /// <summary>
    /// Gets the pay date for this payrun calculator.
    /// </summary>
    public PayDate PayDate { get; }

    /// <summary>
    /// Gets the pay period for this payrun calculator.
    /// </summary>
    public PayReferencePeriod PayPeriod { get; }

    /// <summary>
    /// Initialises a new instance of <see cref="PayrunEntryProcessor"/> with the supplied factories
    /// and specified pay date.
    /// </summary>
    /// <param name="incomeTaxCalcFactory">Income tax calculator factory.</param>
    /// <param name="niCalcFactory">calculator factory.</param>
    /// <param name="pensionCalcFactory">Pension contributions calculator factory.</param>
    /// <param name="studentLoanCalcFactory">Student loan calculator factory.</param>
    /// <param name="payDate">Pay date for this payrun.</param>
    /// <param name="payPeriod">Applicable pay period for this calculator.</param>
    public PayrunEntryProcessor(
        ITaxCalculatorFactory incomeTaxCalcFactory,
        INiCalculatorFactory niCalcFactory,
        IPensionContributionCalculatorFactory pensionCalcFactory,
        IStudentLoanCalculatorFactory studentLoanCalcFactory,
        PayDate payDate,
        PayReferencePeriod payPeriod)
    {
        _incomeTaxCalculators = payDate.TaxYear.GetCountriesForYear()
            .Select(regime => (regime, calculator: incomeTaxCalcFactory.GetCalculator(regime, payDate)))
            .ToDictionary(kv => kv.regime, kv => kv.calculator);
        _niCalculator = niCalcFactory.GetCalculator(payDate);
        _pensionCalculatorFactory = pensionCalcFactory;
        _studentLoanCalculator = studentLoanCalcFactory.GetCalculator(payDate);
        PayDate = payDate;
        PayPeriod = payPeriod;

        _pensionCalculators = new Dictionary<(EarningsBasis, PensionTaxTreatment), IPensionContributionCalculator>();
    }

    /// <summary>
    /// Processes the supplied payrun entry calculating all the earnings and deductions, income tax, national insurance and
    /// other statutory deductions, and generating a result structure which includes the final net pay.
    /// </summary>
    /// <param name="entry">Instance of <see cref="IEmployeePayrunInputEntry"/> containing all the necessary input data for the
    /// payroll calculation.</param>
    /// <param name="result">An instance of <see cref="IEmployeePayrunResult"/> containing the results of the payroll calculations.</param>
    public void Process(IEmployeePayrunInputEntry entry, out IEmployeePayrunResult result)
    {
        GetAllEarningsTypes(ref entry, out var earningsTotals);

        decimal employersNiSavings = 0.0m;
        var workingGrossPay = earningsTotals.WorkingGrossPay;
        var taxablePay = earningsTotals.TaxablePay;
        var nicablePay = earningsTotals.NicablePay;
        INiCalculationResult niCalculationResult;
        IPensionContributionCalculationResult pensionContributions;

        CalculateNiContributions(ref entry, nicablePay, out niCalculationResult);

        if (entry.Employment.PensionScheme == null)
        {
            pensionContributions = PensionContributionCalculationResult.NoPensionApplicable;
        }
        else
        {
            IPensionContributionCalculator calculator = GetPensionCalculator(entry.Employment.PensionScheme.EarningsBasis,
                    entry.Employment.PensionScheme.TaxTreatment);

            if (entry.PensionContributionLevels.SalaryExchangeApplied)
            {
                var salaryExchangedAmount = calculator.GetSalaryExchangedAmount(earningsTotals.PensionablePay,
                    entry.PensionContributionLevels.EmployeeContribution, entry.PensionContributionLevels.EmployeeContributionIsFixedAmount);

                var originalEmployersNi = niCalculationResult.EmployerContribution;

                nicablePay -= salaryExchangedAmount;
                workingGrossPay -= salaryExchangedAmount;
                taxablePay -= salaryExchangedAmount;

                // Have to recalculate the NI contributions based on the adjusted salary
                CalculateNiContributions(ref entry, nicablePay, out niCalculationResult);

                employersNiSavings = originalEmployersNi - niCalculationResult.EmployerContribution;
            }

            // In order to process net pay arrangement pensions or salary exchange correctly, we must first
            // calculate the pension contributions, so we can apply the appropriate impacts on working gross
            // taxable salary figures.
            CalculatePensionContributions(ref entry, earningsTotals.PensionablePay, employersNiSavings,
                out pensionContributions);

            if (!entry.PensionContributionLevels.SalaryExchangeApplied &&
                entry.Employment.PensionScheme?.TaxTreatment == PensionTaxTreatment.NetPayArrangement)
            {
                workingGrossPay -= pensionContributions.CalculatedEmployeeContributionAmount;
                taxablePay -= pensionContributions.CalculatedEmployeeContributionAmount;
            }
        }

        if (!_incomeTaxCalculators.TryGetValue(entry.Employment.TaxCode.ApplicableCountries, out var taxCalculator))
            throw new InvalidOperationException($"Unable to perform tax calculation as calculator for tax regime '{entry.Employment.TaxCode.TaxRegimeLetter}' is not available");

        taxCalculator.Calculate(taxablePay, earningsTotals.BenefitsInKind,
            entry.Employment.TaxCode, entry.Employment.PayrollHistoryYtd.TaxablePayYtd,
            entry.Employment.PayrollHistoryYtd.TaxPaidYtd, entry.Employment.PayrollHistoryYtd.TaxUnpaidDueToRegulatoryLimit,
            out var taxCalculationResult);

        IStudentLoanCalculationResult studentLoanCalculationResult;

        if (entry.Employment.StudentLoanStatus == null)
            studentLoanCalculationResult = StudentLoanCalculationResult.NoStudentLoanApplicable;
        else
            _studentLoanCalculator.Calculate(workingGrossPay, entry.Employment.StudentLoanStatus?.StudentLoanType,
                entry.Employment.StudentLoanStatus?.HasPostGradLoan == true, out studentLoanCalculationResult);

        result = new EmployeePayrunResult(entry.Employee, false, ref taxCalculationResult, ref niCalculationResult, ref studentLoanCalculationResult,
            ref pensionContributions, earningsTotals.GrossPay, workingGrossPay, taxablePay, nicablePay, ref entry.Employment.PayrollHistoryYtd);
    }

    private static void GetAllEarningsTypes(ref IEmployeePayrunInputEntry entry, out EarningsTotals earningsTotals)
    {
        // The distinction between gross pay and working gross pay is that the former is the sum of all
        // earned income for the period, whereas the latter is that figure less any pre-tax deductions,
        // for example, salary exchange arrangements.
        decimal grossPay = 0.0m;
        decimal workingGrossPay = 0.0m;
        decimal taxablePay = 0.0m;
        decimal nicablePay = 0.0m;
        decimal pensionablePay = 0.0m;
        decimal benefitsInKind = 0.0m;

        entry.Earnings.ForEach(e =>
        {
            grossPay += e.TotalEarnings;
            taxablePay += e.EarningsType.IsSubjectToTax ? e.TotalEarnings : 0.0m;
            nicablePay += e.EarningsType.IsSubjectToNi ? e.TotalEarnings : 0.0m;
            pensionablePay += e.EarningsType.IsPensionable ? e.TotalEarnings : 0.0m;
        });

        workingGrossPay = grossPay;

        entry.Deductions.ForEach(d =>
        {
            taxablePay -= d.DeductionType.ReducesTaxablePay ? d.TotalDeduction : 0.0m;
            nicablePay -= d.DeductionType.ReducesNicablePay ? d.TotalDeduction : 0.0m;
            pensionablePay -= d.DeductionType.ReducesPensionablePay ? d.TotalDeduction : 0.0m;
            workingGrossPay -= d.DeductionType.ReducesGrossPay ? d.TotalDeduction : 0.0m;
        });

        entry.PayrolledBenefits.ForEach(b =>
        {
            taxablePay += b.AmountForPeriod;
            benefitsInKind += b.AmountForPeriod;
        });

        earningsTotals = new EarningsTotals()
        {
            GrossPay = grossPay,
            WorkingGrossPay = workingGrossPay,
            TaxablePay = taxablePay,
            NicablePay = nicablePay,
            PensionablePay = pensionablePay,
            BenefitsInKind = benefitsInKind
        };
    }

    private void CalculateNiContributions(ref IEmployeePayrunInputEntry entry, decimal nicablePay, out INiCalculationResult result)
    {
        if (entry.Employment.IsDirector && entry.Employment.DirectorsNiCalculationMethod == Employment.DirectorsNiCalculationMethod.StandardAnnualisedEarningsMethod)
        {
            var (employeesNiPaidYtd, employersNiPaidYtd) = entry.Employment.PayrollHistoryYtd.EmployeeNiHistoryEntries.GetNiYtdTotals();

            _niCalculator.CalculateDirectors(entry.Employment.NiCategory, nicablePay + entry.Employment.PayrollHistoryYtd.NicablePayYtd,
                 employeesNiPaidYtd, employersNiPaidYtd, null, out result);
        }
        else
        {
            _niCalculator.Calculate(entry.Employment.NiCategory, nicablePay, out result);
        }
    }

    private void CalculatePensionContributions(ref IEmployeePayrunInputEntry entry, decimal pensionablePay, decimal employersNiSavings,
        out IPensionContributionCalculationResult result)
    {
        if (entry.Employment.PensionScheme == null)
        {
            result = PensionContributionCalculationResult.NoPensionApplicable;
        }
        else
        {
            IPensionContributionCalculator calculator = GetPensionCalculator(entry.Employment.PensionScheme.EarningsBasis,
                entry.Employment.PensionScheme.TaxTreatment);

            if (entry.PensionContributionLevels.SalaryExchangeApplied)
            {
                calculator.CalculateUnderSalaryExchange(pensionablePay, entry.PensionContributionLevels.EmployerContributionPercentage,
                    employersNiSavings, entry.PensionContributionLevels.EmployersNiReinvestmentPercentage ?? 0.0m,
                    entry.PensionContributionLevels.EmployeeContribution, entry.PensionContributionLevels.EmployeeContributionIsFixedAmount,
                    entry.PensionContributionLevels.AvcForPeriod ?? 0.0m, entry.PensionContributionLevels.SalaryForMaternityPurposes,
                    out result);
            }
            else
            {
                calculator.Calculate(pensionablePay, entry.PensionContributionLevels.EmployerContributionPercentage,
                    entry.PensionContributionLevels.EmployeeContribution, entry.PensionContributionLevels.EmployeeContributionIsFixedAmount,
                    entry.PensionContributionLevels.AvcForPeriod ?? 0.0m, entry.PensionContributionLevels.SalaryForMaternityPurposes,
                    out result);
            }
        }
    }

    private IPensionContributionCalculator GetPensionCalculator(EarningsBasis earningsBasis, PensionTaxTreatment taxTreatment)
    {
        IPensionContributionCalculator? calculator;

        lock (_pensionCalculators)
        {
            if (!_pensionCalculators.TryGetValue((earningsBasis, taxTreatment), out calculator))
            {
                calculator = _pensionCalculatorFactory.GetCalculator(earningsBasis, taxTreatment, PayDate);

                _pensionCalculators.Add((earningsBasis, taxTreatment), calculator);
            }
        }

        return calculator;
    }
}