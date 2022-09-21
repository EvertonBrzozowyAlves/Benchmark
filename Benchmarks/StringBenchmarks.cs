using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmark.Benchmarks
{
    public class StringBenchmarks
    {
        public string uppercaseName = "EVERTON";
        public string lowercaseName = "everton";

        [Benchmark]
        public bool IgualdadeComToLower()
        {
            return uppercaseName.ToLower() == lowercaseName.ToLower();
        }

        [Benchmark]
        public bool IgualdadeComToUpper()
        {
            return uppercaseName.ToUpper() == lowercaseName.ToUpper();
        }

        [Benchmark]
        public bool CompareComIgnoreCase()
        {
            return string.Compare(uppercaseName, lowercaseName, StringComparison.OrdinalIgnoreCase) == 0;
        }

        [Benchmark]
        public bool EqualsIgnoreCase()
        {
            return uppercaseName.Equals(lowercaseName, StringComparison.OrdinalIgnoreCase);
        }
    }
}