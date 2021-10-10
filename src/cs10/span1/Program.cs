using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

[DisassemblyDiagnoser(maxDepth: 1)]
[MemoryDiagnoser(displayGenColumns: false)]
public class Program
{
    public static void Main(string[] args) =>
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
                         .Run(args, DefaultConfig.Instance
        );

    private char[] _array = new char[128];
    private char _c = 'c';

    [Benchmark]
    public void SpanFill() => _array.AsSpan().Fill(_c);

    [Benchmark]
    public void ArrayFill() => Array.Fill(_array, _c);
}