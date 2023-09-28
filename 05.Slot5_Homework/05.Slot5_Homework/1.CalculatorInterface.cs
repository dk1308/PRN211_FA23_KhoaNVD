using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Homework
{
    internal interface CalculatorInterface <T> where T:struct
    {
        T Add(T num1, T num2);
        T Sub(T num1, T num2);
        T Mul(T num1, T num2);
        T Div(T num1, T num2);
    }
}
