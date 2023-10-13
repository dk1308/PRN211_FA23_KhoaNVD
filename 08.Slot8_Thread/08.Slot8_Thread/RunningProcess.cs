using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int no = 1;
            string info;
            //Get all the processes on the local machine, ordered by PId.
            var runningProcs = from proc in Process.GetProcesses(".")
                               orderby proc.Id
                               select proc;
            // Print out PId and Name of each process.
            foreach (var proc in runningProcs)
            {
                Console.WriteLine($"#{no++}. PID:{proc.Id}\tName:{proc.ProcessName}");
            }
            Console.ReadLine();
        }
    }
}
