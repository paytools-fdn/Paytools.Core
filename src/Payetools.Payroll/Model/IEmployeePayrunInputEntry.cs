﻿// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under one of the following licenses:
//
//  * GNU Affero General Public License, see https://www.gnu.org/licenses/agpl-3.0.html
//  * Payetools Commercial Use license [TBA]
//
// For further information on licensing options, see https://paytools.dev/licensing-paytools.html

using Payetools.Pensions.Model;
using System.Collections.Immutable;

namespace Payetools.Payroll.Model;

/// <summary>
/// Represents an employee payrun entry, i.e., all the information needed to prepare the payroll
/// record for the employee for the pay period in question.
/// </summary>
public interface IEmployeePayrunInputEntry
{
    /// <summary>
    /// Gets the employee details for this entry.
    /// </summary>
    IEmployee Employee { get; }

    /// <summary>
    /// Gets the employment details for the employee for this entry.
    /// </summary>
    IEmployment Employment { get; }

    /// <summary>
    /// Gets the list of deductions for this employee for a given payrun.  May be empty.
    /// </summary>
    ImmutableList<IDeductionEntry> Deductions { get; }

    /// <summary>
    /// Gets the list of pay components for this employee for a given payrun.  May be empty but usually not.
    /// </summary>
    ImmutableList<IEarningsEntry> Earnings { get; }

    /// <summary>
    /// Gets the list of payrolled benefits for this employee for a given payrun.  Empty if the employee has
    /// no payrolled benefits.
    /// </summary>
    ImmutableList<IPayrolledBenefitForPeriod> PayrolledBenefits { get; }

    /// <summary>
    /// Gets the pension contributions to apply for this pay period.
    /// </summary>
    IPensionContributionLevels PensionContributionLevels { get; }
}