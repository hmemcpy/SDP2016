using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Tests
{
    [Config(typeof(BenchmarkConfig))]
    public class Enums
    {
        private static ConsoleModifiers modifiers = ConsoleModifiers.Alt | ConsoleModifiers.Control | ConsoleModifiers.Shift;

        [Benchmark]
        public bool HasFlag() => modifiers.HasFlag(ConsoleModifiers.Control);

        [Benchmark]
        public bool Bitwise() => (modifiers & ConsoleModifiers.Control) != 0;
    }
}
