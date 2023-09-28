using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal class GenericConstraint<T> where T: Int16Converter, new()
    {
        public T Value { get; set; }
        public override string ToString() => $"value: {Value}";
    }
}
