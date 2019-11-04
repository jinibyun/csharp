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
            /*
            // threadPool
            // in case of "no" return value
            // ---------------- 1. using c
            // ThreadPool automatically assign thread from ThreadPool and will execute it
            ThreadPool.QueueUserWorkItem(Calc); // radius=null
            ThreadPool.QueueUserWorkItem(Calc, 10.0); // radius=10
            ThreadPool.QueueUserWorkItem(Calc, 20.0);
            Console.ReadLine();

            // theory: 256 thread per CPU.
            // process: 1 cpu, 50 threads
            // 1 thread immediately created, but 49 thread would take time (1 thread per 2 sec : Thread Throttling)
            // To avoid "Thread Throttling" (Thread Delaying), use ThreadPool.SetMaxThreads(), ThreadPool.SetMinThreads() 
            */

            /*
            // NOTE: the below is not supported in net core
            // ---------------- 2. asynchronous delegate
            Func<int, int, int> work = GetArea;
            IAsyncResult asyncRes = work.BeginInvoke(10, 20, null, null);

            Console.WriteLine("Do something in Main thread");

            // EndInvoke is wating for the thread to be finished           
            int result = work.EndInvoke(asyncRes);
            Console.WriteLine("Result: {0}", result);
            */

            // ------------------ 3. backgroundworker class
            // BackgroundWorker comes from "ThreadPool" and event base
            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync(); // acutal execute process
            Console.ReadLine();


            // ------------------ 4. Task (immediate start)
            // same concept as #1. QueueUserWorkItem
            // Task.Factory.StartNew(new Action<object>(Run), null); //create and execute thread immediately
            // Task.Factory.StartNew(new Action<object>(Run), "1st");
            // Task.Factory.StartNew(Run, "2nd");
            // Task.Factory.StartNew( () => Console.WriteLine("test") );

            // ----------------- 5. Task (no immediate start)
            // using new Task
            // Task t1 = new Task(new Action(Run2));

            // // using lambda expression
            // Task t2 = new Task(() =>
            // {
            //     Console.WriteLine("Long query");
            // });

            // // Task thread start
            // t1.Start();
            // t2.Start();

            // // wait for Task to be finished
            // t1.Wait();
            // t2.Wait(); 

            // Console.ReadLine();

            //// ----------------- 6. Task<T> : can have return value
            //Task<int> task = Task.Factory.StartNew<int>(() => CalcSize("Hello World"));

            //// main thread : other job execution
            //Thread.Sleep(1000);

            //// wait
            //int result = task.Result;

            //Console.WriteLine("Result={0}", result);
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

        void Run(object data)
        {            
            Console.WriteLine(data == null ? "NULL" : data);
           
        }

        void Run2()
        {            
            Console.WriteLine("Long running method");
        }

        int CalcSize(string data)
        {
            string s = data == null ? "" : data.ToString();
            // assume complex calculation
            return s.Length;
        }
    }
}