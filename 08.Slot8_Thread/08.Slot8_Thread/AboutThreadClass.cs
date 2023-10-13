using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _08.Slot8_Thread
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Thread myThread = Thread.CurrentThread;
            myThread.Name = "My Thread";
            WriteLine($"ID of my thread: {myThread.ManagedThreadId}");
            WriteLine($"Thread name: {myThread.Name}");
            WriteLine($"Has thread started?: {myThread.IsAlive}");
            WriteLine($"Priority level: {myThread.Priority}");
            WriteLine($"Thread state: {myThread.ThreadState}");
            ReadLine();
        }
    }
}
