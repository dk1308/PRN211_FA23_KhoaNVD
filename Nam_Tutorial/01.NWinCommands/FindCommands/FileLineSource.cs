using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommands
{
    public class FileLineSource : ILineSource
    {
        private int lineNumber;
        private StreamReader? reader;
        private readonly string path;
        private readonly string fileName;

        public FileLineSource(string path, string fileName)
        {
            this.path = path;
            this.fileName = fileName;
        }

        public void Close()
        {
            if(reader != null)
            {
                reader.Close();
                reader = null;
            }
            
        }

        public void Open()
        {
            if(reader != null)
            {
                throw new InvalidOperationException();
            }
            lineNumber = 0;
            reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
        }

        public Line? ReadLine()
        {
            if(reader == null)
            {
                throw new InvalidOperationException();
            }
            var s = reader.ReadLine();
            if (s == null) return null;
            return new Line { LineNumber = ++lineNumber, Text = s};
        }

        public string Name() => this.fileName;
    }
}
