using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsyncApp.Services
{
    internal class PrintService
    {
        DateTime startTime = DateTime.Now;
        TimeSpan futureTime = TimeSpan.FromSeconds(10);
        public void Print()
        {

            while (DateTime.Now - startTime < futureTime)
            {

                Debug.WriteLine($"Time is {DateTime.Now.ToString("hh:mm:ss")} ");
            }

        }

        public void PrintViaThread()
        {

            Thread t = new Thread(Print);
            t.Start();

        }
        public void PrintViaTask()
        {

            Task.Run(Print);
        }

        public Task PrintViaTaskAwaitable()
        {

            return Task.Run(Print);
        }

        public Task<string> PrintViaTaskAwaitableResult()
        {

            return Task.Run(() => {
                Print();
                //after 10 seconds
                return "RRD";

            });
        }

    }
}
