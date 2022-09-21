using BenchmarkDotNet.Running;
using PerformanceBenchmark.Benchmarks;

var summary = BenchmarkRunner.Run<StringBenchmarks>();