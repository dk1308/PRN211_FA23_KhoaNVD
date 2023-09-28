using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Slot7_Lab4
{
    public delegate void MyDele(double val);
    internal class Account
    {
        private double AccountBalance;
        public event MyDele MyEvent;
        public void updateAB(double val)
        {
            this.AccountBalance += val;
            Console.WriteLine($"New account balance: {this.AccountBalance}");
        }
        static void Main(string[] args)
        {
            Account account = new Account();
            account.MyEvent += account.updateAB;
            // Call event first time 
            account.MyEvent(1000);
            // Call event second time
            account.MyEvent(1000);
            // Call event third time 
            account.MyEvent(2000);
            Console.ReadLine();
        }
    }
}
