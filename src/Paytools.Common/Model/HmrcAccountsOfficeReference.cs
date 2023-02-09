﻿// Copyright (c) 2023 Paytools Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
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

using System.Text.RegularExpressions;

namespace Paytools.Common.Model;

/// <summary>
/// Represents an HMRC Accounts Office Reference, as defined at 
/// <see href="https://design.tax.service.gov.uk/hmrc-design-patterns/accounts-office-reference/"/>,
/// which is formatted as follows:
/// <list type="bullet">
///     <item><description>3 numbers</description></item>
///     <item><description>The letter 'P'</description></item>
///     <item><description>8 numbers, or 7 numbers and the letter ‘X’</description></item>
/// </list>
///  (from )
/// </summary>
public record HmrcAccountsOfficeReference
{
    private static readonly Regex _validationRegex = new Regex(@"^[0-9]{3}P[A-Z]\d{7}[0-9X]$");

    private readonly string _accountsOfficeReference;

    /// <summary>
    /// Operator for casting implicitly from a <see cref="HmrcAccountsOfficeReference"/> instance to its string equivalent. 
    /// </summary>
    /// <param name="value">An instance of HmrcAccountsOfficeReference.</param>
    public static implicit operator string(HmrcAccountsOfficeReference value) => value.ToString();

    /// <summary>
    /// Instantiates a new instance of <see cref="HmrcAccountsOfficeReference"/>.
    /// </summary>
    /// <param name="accountsOfficeReference">String value containing the HMRC Accounts Office Reference.</param>
    /// <exception cref="ArgumentException">Thrown if the supplied string value does not match the required pattern
    /// for valid HMRC Accounts Office Reference values.</exception>
    public HmrcAccountsOfficeReference(string accountsOfficeReference)
    {
        var aor = accountsOfficeReference.ToUpper();

        if (!IsValid(aor))
            throw new ArgumentException("Argument is not a valid Accounts Office Reference", nameof(accountsOfficeReference));

        _accountsOfficeReference = aor;
    }

    /// <summary>
    /// Verifies whether the supplied string could be a valid HRMC Accounts Office Reference.
    /// </summary>
    /// <param name="value">String value to check.</param>
    /// <returns>True if the supplied value could be a valid HMRC Accounts Office Reference; false otherwise.</returns>
    /// <remarks>Although this method confirms whether the string supplied <em>could</em> be a valid HRMC Accounts Office
    /// Reference, it does not guarantee that the supplied value is registered with HMRC against a given company.</remarks>
    public static bool IsValid(string value) => _validationRegex.IsMatch(value);

    /// <summary>
    /// Gets the string representation of this HmrcAccountsOfficeReference.
    /// </summary>
    /// <returns>The value of this <see cref="HmrcAccountsOfficeReference"/> as a string.</returns>
    public override string ToString() => _accountsOfficeReference;
}