﻿// Copyright (c) 2023-2024, Payetools Foundation.
//
// Paytools Foundation licenses this file to you under one of the following licenses:
//
//   * GNU Affero General Public License, see https://www.gnu.org/licenses/agpl-3.0.html
//   * Paytools Commercial Use license [TBA]
//
// For further information on licensing options, see https://paytools.dev/licensing-paytools.html

using Payetools.ReferenceData;
using Payetools.Testing.Utils;

namespace Payetools.NationalInsurance.Tests;

public class NiCalculatorFactoryDataFixture : CalculatorFactoryDataFixture<INiCalculatorFactory>
{
    protected override INiCalculatorFactory MakeFactory(IHmrcReferenceDataProvider provider) =>
        new NiCalculatorFactory(provider);
}
