using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Slot20_Async_Await
{
    public class TaskReturn
    {
        static void DoSomething(int time, string message, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{message}...start");
                Console.ResetColor();
            }
            for (int i = 0; i < time; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{message}...end");
                Console.ResetColor();
            }
        }
        static async Task<string> Task2()
        {
            Task<string> t2 = new Task<string>(
                () =>
                {
                    DoSomething(7, "T2", ConsoleColor.Red);
                    return "Return from T2";
                }
                );
            t2.Start();
            var res = await t2;
            Console.WriteLine("T2 Completed!");
            return res;
        }

        static async Task<string> Task3()
        {
            Task<string> t3 = new Task<string>(
                (object obj) =>
                {
                    string t = (string)obj;
                    DoSomething(2, t, ConsoleColor.Magenta);
                    return $"Return from {t}";
                }
                , "T3");
            t3.Start();
            var res = await t3;
            Console.WriteLine("T3 Completed!");
            return res;
        } 

        static void Main(string[] args)
        {
            Task<string> t2 = Task2();
            Task<string> t3 = Task3();
            DoSomething(4, "T1", ConsoleColor.Green);

            Console.WriteLine(t2.Result);
            Console.WriteLine(t3.Result);

            Console.WriteLine("Hello world!");

            Console.ReadLine();
        }
    }
}
