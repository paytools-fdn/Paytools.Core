﻿// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under one of the following licenses:
//
//  * GNU Affero General Public License, see https://www.gnu.org/licenses/agpl-3.0.html
//  * Payetools Commercial Use license [TBA]
//
// For further information on licensing options, see https://paytools.dev/licensing-paytools.html

namespace Payetools.Pensions.Model;

/// <summary>
/// Interface that defines the levels to be applied for contributions into an employee's pension.
/// </summary>
public interface IPensionContributionLevels
{
    /// <summary>
    /// Gets the employee contribution level, either expressed in percentage points (i.e., 5% = 5.0m)
    /// or as a fixed amount (i.e. £500.00), as indicated by the following parameter.
    /// </summary>
    decimal EmployeeContribution { get; }

    /// <summary>
    /// Gets a value indicating whether <see cref="EmployeeContribution"/> should be treated as a fixed amount.  True if the employee
    /// contribution figure sshould be treated as a fixed amount; false if it should be treated as a percentage.
    /// </summary>
    bool EmployeeContributionIsFixedAmount { get; }

    /// <summary>
    /// Gets the employer contribution percentage, expressed in percentage points, i.e., 3% = 3.0m.
    /// </summary>
    decimal EmployerContributionPercentage { get; }

    /// <summary>
    /// Gets a value indicating whether salary exchange should be applied.
    /// </summary>
    bool SalaryExchangeApplied { get; }

    /// <summary>
    /// Gets the percentage of employer's NI saving to be re-invested into the employee's pension as an employer-only
    /// contribution, expressed in percentage points, i.e., 50% = 50.0m.  Only applies under salary exchange.
    /// </summary>
    decimal? EmployersNiReinvestmentPercentage { get; }

    /// <summary>
    /// Gets any Additional Voluntary Contribution (AVC) on the part of the employee.
    /// </summary>
    decimal? AvcForPeriod { get; }

    /// <summary>
    /// Gets the value used to override the employer contribution when an individual is on maternity leave
    /// and should be paid employer contributions based on their contracted salary rather than their
    /// pensionable pay.
    /// </summary>
    decimal? SalaryForMaternityPurposes { get; }
}