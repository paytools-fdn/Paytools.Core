// Copyright (c) 2023-2024, Payetools Foundation.
//
// Paytools Foundation licenses this file to you under one of the following licenses:
//
//   * GNU Affero General Public License, see https://www.gnu.org/licenses/agpl-3.0.html
//   * Paytools Commercial Use license [TBA]
//
// For further information on licensing options, see https://paytools.dev/licensing-paytools.html

using Payetools.Common.Model;

namespace Payetools.Testing.Data.EndToEnd;

public interface IPreviousYtdTestDataEntry
{
    string DefinitionVersion { get; }
    string TestIdentifier { get; }
    TaxYearEnding TaxYearEnding { get; }
    string TestReference { get; }
    decimal StatutoryMaternityPayYtd { get; }
    decimal StatutoryPaternityPayYtd { get; }
    decimal StatutoryAdoptionPayYtd { get; }
    decimal SharedParentalPayYtd { get; }
    decimal StatutoryParentalBereavementPayYtd { get; }
    decimal GrossPayYtd { get; }
    decimal TaxablePayYtd { get; }
    decimal NicablePayYtd { get; }
    decimal TaxPaidYtd { get; }
    decimal StudentLoanRepaymentsYtd { get; }
    decimal GraduateLoanRepaymentsYtd { get; }
    decimal PayrolledBenefitsYtd { get; }
    decimal TaxUnpaidDueToRegulatoryLimit { get; }
    decimal EmployerPensionContributionsYtd { get; }
    decimal EmployeePensionContributionsUnderNpaYtd { get; }
    decimal EmployeePensionContributionsUnderRasYtd { get; }
}
