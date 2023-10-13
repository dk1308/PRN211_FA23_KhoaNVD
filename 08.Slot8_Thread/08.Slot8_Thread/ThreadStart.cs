using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    public class Printerr
    {
        public void PrintNumbers()
        {
            // Display Thread info
            Console.WriteLine($"{Thread.CurrentThread.Name} is executing PrintNumbers()");
            // Print out numbers
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Second thread: {i}");
                Thread.Sleep(2000);
            }
        }
    }
    internal class Program5
    {
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary Thread";
            Console.WriteLine($"{primaryThread.Name} is executing Main()");

            // Call Printer class
            Printerr p = new Printerr();

            // Set PrintNumbers() method to Second Thread
            Thread secondThread = new Thread(new ThreadStart(p.PrintNumbers));
            secondThread.Name = "Second Thread";
            secondThread.Start();

            // Create Main Thread
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{primaryThread.Name} is close");
            Console.ReadLine();
        }
    }
}
