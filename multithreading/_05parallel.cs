using System;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    public class _05parallel
    {
        public void DoTest(){
            // procedural
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("{0}: {1}", 
                    Thread.CurrentThread.ManagedThreadId, i);                
            }
            Console.Read();

            // parallel
            // multi thread parallel processing
            //
            Parallel.For(0, 1000, (i) => {                
                Console.WriteLine("{0}: {1}", 
                    Thread.CurrentThread.ManagedThreadId, i);                
            });
        }
    }
}