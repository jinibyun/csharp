using System;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // no parameter method : _01basic and _02otherClass
            // var obj = new _01basic();
            // var obj = new _02otherClass();

            // parameter: ParameterizedThreadStart
            // var obj = new _03parameterizedThread();

            // threadPool
            // var obj = new _04threadPool();

            // parallel
            var obj = new _05parallel();
            obj.DoTest();
        }
    }
}
