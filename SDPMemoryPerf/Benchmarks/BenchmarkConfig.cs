using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Validators;

namespace Benchmarks
{
    internal class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            Add(Job.Clr.WithLaunchCount(1));
            Add(JitOptimizationsValidator.FailOnError);
            Add(new MemoryDiagnoser());
        }
    }
}