using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Tuple_Discard
{
    internal class Discard
    {
        static void Main(string[] args)
        {
            String[] arr = { "hello", "world", "3.14", "5.5555" };
            CheckDouble(arr);

            (String lastName, _, String firstName) = SplitName("Vo Huy Hoang");
            Console.WriteLine($"first name: {firstName}; last name: {lastName}");
        }

        public static void CheckDouble(String[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.TryParse(arr[i], out _))
                {
                    Console.WriteLine($"{arr[i]} is double");
                }
                else Console.WriteLine($"{arr[i]} is not double");
            }
        }

        public static (String lastName, String middleName, String firstName) SplitName(String name)
        {
            String[] nameArr = name.Split(" ");
            return (nameArr[0], nameArr[1], nameArr[2]);
        }
    }
}
