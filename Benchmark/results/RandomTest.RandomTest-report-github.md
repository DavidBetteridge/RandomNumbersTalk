``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-6440HQ CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT


```
|       Method |     Mean |    Error |   StdDev |
|------------- |---------:|---------:|---------:|
| SystemRandom | 26.96 ms | 2.673 ms | 7.497 ms |
|       Crypto | 24.81 ms | 1.573 ms | 4.564 ms |
