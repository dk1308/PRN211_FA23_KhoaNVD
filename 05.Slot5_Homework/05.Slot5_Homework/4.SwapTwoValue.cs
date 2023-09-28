using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Homework
{
    internal class SwapTwoValue
    {
        public void DoSwap<T>( ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
