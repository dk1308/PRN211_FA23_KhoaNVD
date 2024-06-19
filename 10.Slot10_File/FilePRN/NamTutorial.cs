using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePRN
{
    internal class NamTutorial
    {
        static void Main(string[] args)
        {
            string path = "D:\\Dev\\Course\\.Net_course\\10.Slot10_File\\FilePRN";
            string src = "D:\\Dev\\Course\\.Net_course\\10.Slot10_File\\FilePRN\\test.txt.txt";
            string dest = "D:\\Dev\\Course\\.Net_course\\10.Slot10_File\\FilePRN\\test-copy.txt.txt";
            //GetDirAndLog(path);
            WriteFile(src, dest);
        }

        static void GetDirAndLog(string path)
        {
            var dir = new DirectoryInfo(path);
            var dirInfos = dir.GetDirectories();

            Console.WriteLine("\n\n");

            // last written time
            foreach (var dirInfo in dirInfos)
            {
                Console.WriteLine($"{dirInfo.LastWriteTime:MM/dd/yyyy} {dirInfo.LastWriteTime:HH:mm tt}   <DIR>     {dirInfo.Name}");
            }

            var fileInfos = dir.GetFiles();
            // length
            foreach (var fileInfo in fileInfos)
            {
                Console.WriteLine($"{fileInfo.LastWriteTime:MM/dd/yyyy} {fileInfo.LastWriteTime:HH:mm tt}   {fileInfo.Length:#,#}     {fileInfo.Name}");
            }
        }
        
        static void ReadFile(string src)
        {
            byte[] buffer = new byte[2];
            FileStream instream = File.OpenRead(src);
            var res = instream.Read(buffer, 0, buffer.Length);
            while (res > 0)
            {
                Console.WriteLine(res);
                res = instream.Read(buffer, 0, buffer.Length);
            }
            instream.Close();
        }

        static void WriteFile(string src, string dest)
        {
            byte[] buffer = new byte[2];
            FileStream instream = File.OpenRead(src);
            FileStream outstream = File.OpenWrite(dest);
            int res = instream.Read(buffer, 0, buffer.Length);
            while (res > 0)
            {
                outstream.Write(buffer, 0, res);
                res = instream.Read(buffer, 0, buffer.Length);
            }
            instream.Close();
            outstream.Close();
        }
    }
}
