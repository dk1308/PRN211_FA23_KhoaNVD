using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityConsole
{
    public class MyGenericClass<T>
    {
        private T value;
        public T Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
