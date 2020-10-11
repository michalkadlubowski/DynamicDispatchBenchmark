using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DynamicDispatchBenchmark.Dynamic;

namespace DynamicDispatchBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DispatchBenchmark>();
        }
    }

    public class DispatchBenchmark
    {
        [Benchmark]
        public List<string> Dynamic()
        {
            return new DynamicDispatch().TestDispatch();
        }
        [Benchmark]
        public List<string> Visitor()
        {
            return new DynamicDispatch().TestDispatch();
        }        
    }
}
