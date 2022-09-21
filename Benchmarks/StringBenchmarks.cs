using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmark.Benchmarks
{
    public class StringBenchmarks
    {
        public string nomeV1 = "Everton";
        public string nomeV2 = "everton";

        [Benchmark]
        public bool IgualdadeComToLower()
        {
            return nomeV1.ToLower() == nomeV2.ToLower();
        }

        [Benchmark]
        public bool IgualdadeComToUpper()
        {
            return nomeV1.ToUpper() == nomeV2.ToUpper();
        }

        [Benchmark]
        public bool CompareComIgnoreCase()
        {
            return string.Compare(nomeV1, nomeV2, StringComparison.OrdinalIgnoreCase) == 0;
        }

        [Benchmark]
        public bool EqualsIgnoreCase()
        {
            return nomeV1.Equals(nomeV2, StringComparison.OrdinalIgnoreCase);
        }
    }
}