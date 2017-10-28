using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoardCSharp.Common;

namespace DashBoardCSharp.TestCases
{
    [TestClass]
    public class Test
    {
        [TestInitialize]
        public void TestInitializeMethod()
        {
            Console.WriteLine("Run Test Initialize");
        }

        [TestCleanup]
        public void TestCleanupMethod()
        {
            Console.WriteLine("Run Test Cleanup");
        }

        [TestMethod]
        public void TC01()
        {
            Utilities.SplitText("Item1|Item3|Item2");
        }
    }
}
