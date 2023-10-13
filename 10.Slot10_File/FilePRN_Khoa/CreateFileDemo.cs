using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePRN_Khoa
{
    internal class CreateFileDemo
    {
        static void Main(string[] args)
        {
            String path = @"MyFile.txt";
            if(File.Exists(path))
            {
                // Create a file to write on
                using StreamWriter sw = File.CreateText(path);
                sw.Write("Hello");
                sw.WriteLine("World");
                sw.Write("hehe");
            }
            // Open the file to read from
            using StreamReader sr = File.OpenText(path);
            string s;
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
