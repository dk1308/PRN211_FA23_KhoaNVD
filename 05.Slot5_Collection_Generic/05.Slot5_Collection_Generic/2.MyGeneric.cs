using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal class MyGeneric <T>
    {
        public T Value { get; set; }

        public override string? ToString() => $"Value: {Value}";
    }
}
