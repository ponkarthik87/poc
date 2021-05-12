``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|           Method |        Mean |     Error |    StdDev | Ratio | RatioSD | Rank |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
|----------------- |------------:|----------:|----------:|------:|--------:|-----:|----------:|----------:|---------:|----------:|
|       ListAddInt |    651.9 μs |   9.43 μs |   8.36 μs |  1.00 |    0.00 |    1 |  285.1563 |  285.1563 | 285.1563 |      1 MB |
|       DictAddInt |  2,083.1 μs |  37.63 μs |  35.20 μs |  3.20 |    0.07 |    2 | 1050.7813 |  996.0938 | 996.0938 |   5.76 MB |
|    HashSetAddInt |  2,421.3 μs |  21.44 μs |  17.91 μs |  3.72 |    0.06 |    3 |  984.3750 |  949.2188 | 949.2188 |   4.61 MB |
|    ListAddPerson |  3,613.7 μs |  51.59 μs |  45.74 μs |  5.54 |    0.10 |    4 |  750.0000 |  503.9063 | 496.0938 |   5.05 MB |
| HashSetAddPerson | 12,194.8 μs | 234.22 μs | 260.34 μs | 18.77 |    0.51 |    5 | 1437.5000 | 1390.6250 | 937.5000 |   8.81 MB |
|    DictAddPerson | 13,464.9 μs |  92.92 μs |  86.92 μs | 20.64 |    0.29 |    6 | 1203.1250 | 1000.0000 | 812.5000 |  11.11 MB |
