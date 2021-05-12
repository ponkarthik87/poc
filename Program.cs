using System;
using BenchmarkDotNet.Running;

namespace TestBenchMark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<CollectionsAddBenchMark>();
            BenchmarkRunner.Run<CollectionsContainsBenchMark>();
            BenchmarkRunner.Run<CollectionsRemoveBenchMark>();

        }
    }
}
