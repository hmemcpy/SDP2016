using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Tests
{
    [Config(typeof(BenchmarkConfig))]
    public class Loops
    {
        const int MaxCounter = 1000;
        private readonly List<int> initialValuesList = Enumerable.Range(0, MaxCounter).ToList();

        [Benchmark]
        public int ForLoopList()
        {
            var counter = 0;
            for (int i = 0; i < initialValuesList.Count; i++)
                counter += initialValuesList[i];
            return counter;
        }

        [Benchmark]
        public int ForEachList()
        {
            var counter = 0;
            foreach (var i in initialValuesList)
                counter += i;
            return counter;
        }

        [Benchmark]
        public int ForEachListAsIEnumerable()
        {
            var counter = 0;
            foreach (var i in initialValuesList as IEnumerable<int>)
                counter += i;
            return counter;
        }
    }
}