﻿using Paytools.Common;
using Test = Paytools.IncomeTax.Tests.TaxCodeTestHelper;

namespace Paytools.IncomeTax.Tests;

public class StandardTaxCodeTests
{
    [Fact]
    public void Check1257LCode()
    {
        Test.RunStandardCodeTest("1257L", new(TaxYearEnding.Apr5_2023), TaxTreatment.L, 12570,
            CountriesForTaxPurposes.England | CountriesForTaxPurposes.NorthernIreland);
        Test.RunStandardCodeTest("S1257L", new(TaxYearEnding.Apr5_2023), TaxTreatment.L, 12570,
            CountriesForTaxPurposes.Scotland);
        Test.RunStandardCodeTest("C1257L", new(TaxYearEnding.Apr5_2023), TaxTreatment.L, 12570,
            CountriesForTaxPurposes.Wales);
    }

    [Fact]
    public void CheckKCodes()
    {
        Test.RunStandardCodeTest("K1052", new(TaxYearEnding.Apr5_2023), TaxTreatment.K, -10520,
            CountriesForTaxPurposes.England | CountriesForTaxPurposes.NorthernIreland);
        Test.RunStandardCodeTest("SK1234", new(TaxYearEnding.Apr5_2023), TaxTreatment.K, -12340,
            CountriesForTaxPurposes.Scotland);
        Test.RunStandardCodeTest("CK2345", new(TaxYearEnding.Apr5_2023), TaxTreatment.K, -23450,
            CountriesForTaxPurposes.Wales);
    }

    [Fact]
    public void CheckInvalidCode()
    {
        var result = TaxCode.TryParse("AB123C", new(TaxYearEnding.Apr5_2023), out var taxCode);

        Assert.False(result);
    }
}