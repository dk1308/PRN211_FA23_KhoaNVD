using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace FindCommands.Tests
{
    [TestClass()]
    public class FindCommandsTests
    {
        [TestMethod()]
        public void BuildOptionsTest()
        {
            string[] args = new string[] { "/v", "/c", "/n" };
            var options = Program.BuildOptions(args);

            Assert.IsNotNull(options);
            Assert.IsTrue(options.FindDontConstain);
            Assert.IsTrue(options.CountMode);
            Assert.IsTrue(options.ShowLineNumber);
        }
    }
}