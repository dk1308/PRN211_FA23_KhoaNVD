using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _08.Slot8_Thread
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Get access to the AppDomain for the current thread
            AppDomain defaultAD = AppDomain.CurrentDomain;
            // Get all loaded assemblies in the default Appdomain
            Assembly[] loadAssemblies = defaultAD.GetAssemblies();
            Console.WriteLine("The assemblies loaded in {0}", defaultAD.FriendlyName);
            foreach (Assembly assembly in loadAssemblies)
            {
                Console.WriteLine($"--Name, Version: {assembly.GetName().Name}:{assembly.GetName().Version}");
            }
            Console.ReadLine();
        }
    }
}
