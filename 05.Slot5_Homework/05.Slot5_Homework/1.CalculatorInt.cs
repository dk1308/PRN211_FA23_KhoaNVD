using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Homework
{
    internal class CalculatorInt : CalculatorInterface<int>
    {
        public int Add(int num1, int num2) => num1 + num2;

        public int Div(int num1, int num2) => num1 - num2;

        public int Mul(int num1, int num2) => num1 * num2;

        public int Sub(int num1, int num2) => num1 / num2;
    }
}
