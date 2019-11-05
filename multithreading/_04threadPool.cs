using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    public class _04threadPool
    {
        // private BackgroundWorker worker;
        public void DoTest()
        {
            // threadPool
            // in case of "no" return value            
            // ThreadPool automatically assign thread from ThreadPool and will execute it
            ThreadPool.QueueUserWorkItem(Calc); // radius=null
            ThreadPool.QueueUserWorkItem(Calc, 10.0); // radius=10
            ThreadPool.QueueUserWorkItem(Calc, 20.0);
            Console.ReadLine();

            // theory: 256 thread per CPU.
            // process: 1 cpu, 50 threads
            // 1 thread immediately created, but 49 thread would take time (1 thread per 2 sec : Thread Throttling)
            // To avoid "Thread Throttling" (Thread Delaying), use ThreadPool.SetMaxThreads(), ThreadPool.SetMinThreads() 


            /*
            // NOTE: the below is not supported in net core
            // asynchronous delegate
            Func<int, int, int> work = GetArea;
            IAsyncResult asyncRes = work.BeginInvoke(10, 20, null, null);

            Console.WriteLine("Do something in Main thread");

            // EndInvoke is wating for the thread to be finished           
            int result = work.EndInvoke(asyncRes);
            Console.WriteLine("Result: {0}", result);
            */

        }





        void Calc(object radius)
        {
            if (radius == null) return;

            double r = (double)radius;
            double area = r * r * 3.14;
            Console.WriteLine("r={0}, area={1}", r, area);
        }

        int GetArea(int height, int width)
        {
            int area = height * width;
            return area;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {            
            Console.WriteLine("... Long running task ...");
        }
    }
}