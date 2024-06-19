using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommands
{
    public interface ILineSource
    {
        public string Name();
        public Line? ReadLine();
        public void Open();
        public void Close();
    }
}
