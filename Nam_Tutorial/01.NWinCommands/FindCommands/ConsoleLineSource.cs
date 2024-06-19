using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommands
{
    public class ConsoleLineSource : ILineSource
    {
        private int lineNumber = 0;
        public void Close()
        {
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
        }

        public Line? ReadLine()
        {
            var s = Console.ReadLine();
            if(s == null)
                return null;
            return new Line { LineNumber = ++lineNumber, Text = s };
        }
    }
}
