# Benchmark

A sample project that runs a benchmark using the package **BenchmarkDotNet**.  

To run the benchmarks:  
```bash
dotnet run --configuration Release
```

The ouput will be similar to the following:  

|                Method |      Mean |     Error |    StdDev |
|---------------------- |----------:|----------:|----------:|
|   EqualityWithToLower | 41.969 ns | 0.1442 ns | 0.1204 ns |
|   EqualityWithToUpper | 49.608 ns | 0.3365 ns | 0.2983 ns |
| CompareWithIgnoreCase | 10.385 ns | 0.1033 ns | 0.0966 ns |
|  EqualsWithIgnoreCase |  6.693 ns | 0.0382 ns | 0.0319 ns |