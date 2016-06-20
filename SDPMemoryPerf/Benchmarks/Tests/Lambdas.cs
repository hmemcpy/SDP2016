using System;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Tests
{
    [Config(typeof(BenchmarkConfig))]
    public class Lambdas
    {
        [Benchmark]
        public bool WithInstance() => Do(() => SayHello("Hello"));

        [Benchmark]
        public bool WithStatic() => Do(() => SayHelloStatic("Hello"));

        [Benchmark]
        public bool WithCapturedVariable()
        {
            string data = "via lambda (that has a closure)";
            return Do(() => SayHelloStatic(data));
        }

        [Benchmark]
        public bool WithPassthrough()
        {
            return Do("Hello", x => SayHelloStatic(x));
        }

        [Benchmark]
        public bool MethodGroup() => Do(SayHello);









        void SayHello() { }
        void SayHello(string s) => GC.KeepAlive(s);
        static void SayHelloStatic(string s) => GC.KeepAlive(s);
        
        static bool Do(Action action)
        {
            action();
            return true;
        }

        static bool Do(string value, Action<string> action)
        {
            action(value);
            return true;
        }
    }
}
