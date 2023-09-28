using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal interface GenericInterface <T> where T: struct
    {
        public T Add(T num1, T num2);
    }

    class myClass1 : GenericInterface<int>
    {
        public int Add(int num1, int num2) => num1 + num2;
    }

    class myClass2 : GenericInterface<float>
    {
        public float Add(float num1, float num2) => num1 + num2;
    }
}
