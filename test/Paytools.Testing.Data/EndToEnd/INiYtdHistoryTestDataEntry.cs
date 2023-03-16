// Copyright (c) 2023 Paytools Foundation.
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

using Paytools.NationalInsurance.Model;
using Paytools.Common.Model;

namespace Paytools.Testing.Data.EndToEnd;

public interface INiYtdHistoryTestDataEntry
{
    string DefinitionVersion { get; }
    string TestIdentifier { get; }
    TaxYearEnding TaxYearEnding { get; }
    string TestReference { get; }
    NiCategory NiCategoryPertaining { get; }
    decimal GrossNicableEarnings { get; }
    decimal EmployeeContribution { get; }
    decimal EmployerContribution { get; }
    decimal TotalContribution { get; }
    decimal EarningsUpToAndIncludingLEL { get; }
    decimal EarningsAboveLELUpToAndIncludingST { get; }
    decimal EarningsAboveSTUpToAndIncludingPT { get; }
    decimal EarningsAbovePTUpToAndIncludingFUST { get; }
    decimal EarningsAboveFUSTUpToAndIncludingUEL { get; }
    decimal EarningsAboveUEL { get; }
    decimal EarningsAboveSTUpToAndIncludingUEL { get; }
}
