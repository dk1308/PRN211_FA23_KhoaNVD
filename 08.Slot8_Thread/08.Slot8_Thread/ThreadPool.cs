using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    internal class Program8
    {
        static void PrintNumbers(object state)
        {
            Printerr task = (Printerr)state;
            task.PrintNumbers();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with timer type *****");
            Console.WriteLine("***** Main thread started. ThreadID ={0} *****",Thread.CurrentThread.ManagedThreadId);
            Printerr p = new Printerr();
            WaitCallback workItem = new WaitCallback(PrintNumbers);
            // Queue the method 10 times
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All tasks queued.");
            Console.ReadLine();
        }
    }
}
