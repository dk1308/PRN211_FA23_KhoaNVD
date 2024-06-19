using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommands
{
    public class FilteredLineSource : ILineSource 
    {
        private readonly ILineSource parent;
        private Func<Line, bool> f;
        public FilteredLineSource(ILineSource? parent, Func<Line, bool>? f = null)
        {
            if(parent == null) throw new ArgumentNullException("parent is null");
            this.parent = parent;
            this.f = f;
        }

        public void Close()
        {
            parent.Close();
        }

        public string Name() => parent.Name();

        public void Open()
        {
            parent.Open();
        }

        public Line? ReadLine()
        {
            if(f is null) return parent.ReadLine();

            var line = parent.ReadLine();

            while (line != null && f(line) == false) line = parent.ReadLine();
            return line;
        }
    }
}
