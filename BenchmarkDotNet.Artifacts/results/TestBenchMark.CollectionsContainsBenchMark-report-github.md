``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                Method |           Mean |         Error |        StdDev |         Median |  Ratio | RatioSD | Rank |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |---------------:|--------------:|--------------:|---------------:|-------:|--------:|-----:|---------:|------:|------:|----------:|
|       DictContainsInt |       849.4 μs |      16.95 μs |      32.26 μs |       840.4 μs |  0.004 |    0.00 |    1 |        - |     - |     - |      96 B |
|    HashSetContainsInt |       886.2 μs |       7.24 μs |       5.65 μs |       884.8 μs |  0.004 |    0.00 |    2 |        - |     - |     - |      96 B |
|    DictContainsPerson |     2,058.7 μs |      41.12 μs |      38.47 μs |     2,060.6 μs |  0.009 |    0.00 |    3 | 132.8125 |     - |     - |  640104 B |
| HashSetContainsPerson |     2,290.2 μs |      96.69 μs |     277.41 μs |     2,171.7 μs |  0.010 |    0.00 |    4 | 132.8125 |     - |     - |  640104 B |
|       ListContainsInt |   219,933.7 μs |   4,377.32 μs |   4,495.19 μs |   219,467.9 μs |  1.000 |    0.00 |    5 |        - |     - |     - |     731 B |
|    ListContainsPerson | 5,666,311.0 μs | 111,757.54 μs | 207,149.76 μs | 5,596,830.9 μs | 26.559 |    0.51 |    6 |        - |     - |     - |  640104 B |
