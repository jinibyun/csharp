using System;
using System.IO;
using System.Net;
using System.Timers;

namespace multithreading
{
    public class _06timer
    {
        public void DoTest(){
            
            // Timer support "multi" thread
            Timer timer = new System.Timers.Timer();
            timer.Interval = 60 * 60* 1000; // 1 시간
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        // work thread from thread-pool is executing
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // download html
            WebClient web = new WebClient();
            string webpage = web.DownloadString("http://mssql.tools");

            // save downloaded html to text file
            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = string.Format("page_{0}.html", time);            
            File.WriteAllText(outputFile, webpage);            
        }
    }
}