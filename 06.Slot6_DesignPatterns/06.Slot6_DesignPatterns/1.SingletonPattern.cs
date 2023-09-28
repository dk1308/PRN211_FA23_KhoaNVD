using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Slot6_DesignPatterns
{
    internal class Singleton
    {
        private static readonly Singleton Instance;
        private static int TotalInstance = 0;
        private Singleton() => Console.WriteLine("Private Singleton constructor is called!");

        static Singleton()
        {
            Console.WriteLine("Static Singleton constructor is called!");
            Instance = new Singleton();
            TotalInstance++;
            Console.WriteLine($"Singleton instance is created. Number of instance:{TotalInstance}!");
            Console.WriteLine("--Exit from static constructor!");
        }

        public static Singleton GetInstace() => Instance;
        public int TotalInstace() => TotalInstance;
        public void Print() => Console.WriteLine("Hello world");


        
    }

    class Program
    {
        //Main function
        static void Main(string[] args)
        {
            Console.WriteLine("#1. Trying to get a Singleton instance, called firstInstance");
            Singleton firstInstance = Singleton.GetInstace();
            Console.Write("--Invoke Print() method: ");
            firstInstance.Print();
            Console.WriteLine("#2. Trying to get another Singleton instance, called secondInstance");
            Singleton secondInstance = Singleton.GetInstace();
            Console.WriteLine($"Number of instance: {secondInstance.TotalInstace()}");
            Console.Write("--Invoke Print() method: ");
            secondInstance.Print();

            // Check whether two instance is equal
            if (secondInstance.Equals(firstInstance))
            {
                Console.WriteLine("2 instance are the same.");
            }
            else Console.WriteLine("Different instances exist.");

            Console.ReadLine();
        }
    }
}
