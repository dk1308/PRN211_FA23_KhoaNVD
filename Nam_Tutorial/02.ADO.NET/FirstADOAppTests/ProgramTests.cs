using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstADOApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstADOApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestDBConnectionTest()
        {
            Program.TestDBConnection();
        }
    }
}