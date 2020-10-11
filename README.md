# DynamicDispatchBenchmark
This repo contains some benchmarks for some solutions to dynamic/multiple dispatch problem in C#

|  Method |     Mean |   Error |   StdDev |   Median |
|-------- |---------:|--------:|---------:|---------:|
| Dynamic | 435.1 ns | 8.02 ns | 18.11 ns | 425.1 ns |
| Visitor | 425.2 ns | 3.33 ns |  2.78 ns | 425.4 ns |

// * Hints *
Outliers
  DispatchBenchmark.Dynamic: Default -> 16 outliers were removed (513.07 ns..621.74 ns)
  DispatchBenchmark.Visitor: Default -> 2 outliers were removed (432.46 ns, 433.00 ns)