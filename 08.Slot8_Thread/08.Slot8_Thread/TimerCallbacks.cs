using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    internal class Program7
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}. Param is {1}", DateTime.Now.ToLongTimeString, state.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with timer type *****");
            // Create the delegate for the timer type
            TimerCallback timeCB = new TimerCallback(PrintTime);
            // Establish timer settings.
            var _ = new Timer(
                timeCB,             // The timeCallback delegate object
                "Hello From Main",  // Any info to pass into the called method
                0,                  // Amount of time to wait before starting (in milliseconds)
                1000);              // Interval of time between calls (in milliseconds)
            Console.ReadLine();
        }
    }
}
