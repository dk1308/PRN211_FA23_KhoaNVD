using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal class MyCollection
    {
        private System.Collections.ArrayList a = new System.Collections.ArrayList();
        public int GetInt (int pos) => (int)a[pos];
        public void AddInt (int value) => a.Add(value);

        public int Count() => a.Count;
    }
}
