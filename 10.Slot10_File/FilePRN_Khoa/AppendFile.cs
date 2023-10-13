using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePRN_Khoa
{
    internal class AppendFile
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            if(File.Exists(path))
            {
                string createText = "Create Text" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "Append Text";
            File.AppendAllText(path, appendText);
            // using StreamReader to read from file
            using StreamReader sr = File.OpenText(path);
            String res;
            while ((res =sr.ReadLine()) != null) { 
                Console.WriteLine(res);
            }
        }
    }
}
