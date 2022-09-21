using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmark.Benchmarks
{
    public class StringBenchmarks
    {
        public string uppercaseName = "EVERTON";
        public string lowercaseName = "everton";

        [Benchmark]
        public bool EqualityWithToLower()
        {
            return uppercaseName.ToLower() == lowercaseName.ToLower();
        }

        [Benchmark]
        public bool EqualityWithToUpper()
        {
            return uppercaseName.ToUpper() == lowercaseName.ToUpper();
        }

        [Benchmark]
        public bool CompareWithIgnoreCase()
        {
            return string.Compare(uppercaseName, lowercaseName, StringComparison.OrdinalIgnoreCase) == 0;
        }

        [Benchmark]
        public bool EqualsWithIgnoreCase()
        {
            return uppercaseName.Equals(lowercaseName, StringComparison.OrdinalIgnoreCase);
        }
    }
}