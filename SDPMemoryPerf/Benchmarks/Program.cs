using BenchmarkDotNet.Running;
using Benchmarks.Tests;

namespace Benchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Lambdas>();
            //BenchmarkRunner.Run<Loops>();
            //BenchmarkRunner.Run<Enums>();
        }
    }
}