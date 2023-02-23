﻿// Copyright (c) 2023 Paytools Foundation.  All rights reserved.
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

namespace Paytools.NationalMinimumWage;

/// <summary>
/// Interface for types that provide National Minimum/Living Wage evaluations.
/// </summary>
public interface INmwEvaluator
{
    /// <summary>
    /// Evauates whether an employee's pay is compliant with the NMW/NLW regulations by considering their pay, hours and date of
    /// birth.  Note that apprentices have special treatment.
    /// </summary>
    /// <param name="payPeriod">Applicable pay period.</param>
    /// <param name="dateOfBirth">Employee's date of birth.</param>
    /// <param name="grossPay">Gross pay to be used for the evaluation.  This pay should correspond to the number of hours worked
    /// given in the subequent parameter.</param>
    /// <param name="hoursWorkedForPay">Hours worked that corresponds to the gross pay figure supplied.</param>
    /// <param name="isApprentice">True if the employee is an apprentice; false otherwise.  Optional, defaults to false.</param>
    /// <param name="yearsAsApprentice">Number of years an apprentice has served in their apprenticeship.  May be a figure less
    /// than one.  Optional, defaults to null; not required if the employee is not an apprentice.</param>
    /// <returns>An instance of <see cref="NmwEvaluationResult"/> that indicates whether the pay is compliant with the NMW/NLW
    /// regulations.</returns>
    /// <remarks>As per <see href="https://www.gov.uk/hmrc-internal-manuals/national-minimum-wage-manual/nmwm03010"/>,
    /// the rate that applies to each worker depends on their age at teh start of the pay reference period.</remarks>
    NmwEvaluationResult Evaluate(
        PayReferencePeriod payPeriod,
        DateOnly dateOfBirth,
        decimal grossPay,
        decimal hoursWorkedForPay,
        bool isApprentice = false,
        decimal? yearsAsApprentice = null);
}