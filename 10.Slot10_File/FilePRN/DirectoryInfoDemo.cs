using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePRN
{
    class DirectoryInfoDemo
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Dev\Course\.Net course"); 
            Console.WriteLine("Search pattern bin* returns: "); 
            foreach (var fi in di.GetDirectories("bin*"))
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Search pattern TopDirectoryOnly returns:");
            foreach (var fi in di.GetFiles("*.cs", SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(fi.Name);
            }
            Console.ReadLine();
        }
    }
}
