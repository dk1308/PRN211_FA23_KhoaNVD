using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    class MyParam
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }
    internal class Program6
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void AddNumber(object data)
        {
            if (data is MyParam p)
            {
                Thread.Sleep(1000);
                Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"{p.Value1} + {p.Value2} = {p.Value1 + p.Value2}");
                // Tell other thread we are done
                waitHandle.Set();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId);
            // Make an MyParam object to pass to the secondary thread
            MyParam p = new MyParam { Value1 = 8, Value2 =15};
            Thread t = new Thread(new ParameterizedThreadStart(AddNumber));
            // Set to background thread
            t.IsBackground = true;
            t.Start(p);
            // Wait for the wait handle to complete
            waitHandle.WaitOne();
            Console.WriteLine("Main thread: Done");
            Console.ReadLine();
        }
    }
}
