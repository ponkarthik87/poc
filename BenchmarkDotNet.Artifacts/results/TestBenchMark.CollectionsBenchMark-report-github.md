``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|         Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Rank |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|--------------- |----------:|----------:|----------:|------:|--------:|-----:|----------:|----------:|----------:|----------:|
|    ListTestInt |  7.026 ms | 0.1397 ms | 0.1495 ms |  1.00 |    0.00 |    1 | 1968.7500 | 1968.7500 | 1968.7500 |      8 MB |
| HashSetTestInt | 25.425 ms | 0.4964 ms | 0.5717 ms |  3.62 |    0.10 |    2 | 1187.5000 | 1156.2500 | 1156.2500 |  41.11 MB |
