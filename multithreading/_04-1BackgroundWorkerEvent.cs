using System;
using System.Collections.Generic;
using System.Text;

namespace multithreading
{
    public class _04_1BackgroundWorkerEvent
    {
        public void DoTest()
        {
            // BackgroundWorker class's events
            // 1. DoWork : "Worker thread". it cannot access to UI control
            // On cancelling,  call CancelAsync()
            // check with CancellationPending property if it is cancelled or not

            // 2. ProgressChanged: "UI Thread". it can access to UI control
            // 3. RunWorkerCompleted: "UI Thread". it can access to UI control

        }
    }
}
