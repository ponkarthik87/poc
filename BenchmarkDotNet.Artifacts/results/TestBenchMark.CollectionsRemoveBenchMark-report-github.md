``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|              Method |           Mean |        Error |       StdDev |  Ratio | RatioSD | Rank |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------------:|-------------:|-------------:|-------:|--------:|-----:|---------:|------:|------:|----------:|
|       DictRemoveInt |       749.7 μs |      5.37 μs |      4.49 μs |  0.002 |    0.00 |    1 |        - |     - |     - |     104 B |
|    HashSetRemoveInt |       861.0 μs |     16.48 μs |     16.92 μs |  0.003 |    0.00 |    2 |        - |     - |     - |      96 B |
| HashSetRemovePerson |     2,001.4 μs |     13.99 μs |     11.68 μs |  0.006 |    0.00 |    3 | 132.8125 |     - |     - |  640107 B |
|    DictRemovePerson |     2,006.1 μs |     19.34 μs |     18.09 μs |  0.006 |    0.00 |    3 | 132.8125 |     - |     - |  640106 B |
|       ListRemoveInt |   345,471.7 μs |  1,636.97 μs |  1,366.95 μs |  1.000 |    0.00 |    4 |        - |     - |     - |      96 B |
|    ListRemovePerson | 6,706,046.0 μs | 88,932.95 μs | 78,836.74 μs | 19.391 |    0.22 |    5 |        - |     - |     - |  641344 B |
