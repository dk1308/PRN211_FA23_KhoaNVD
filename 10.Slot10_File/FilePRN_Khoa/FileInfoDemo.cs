using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePRN_Khoa
{
    internal class FileInfoDemo
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            FileInfo fi = new FileInfo(path);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
        }
    }
}
