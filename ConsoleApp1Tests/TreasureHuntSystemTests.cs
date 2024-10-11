using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class TreasureHuntSystemTests
    {
        [TestMethod()]
        public void MaxTreasureValueTest()
        {
            int[] treasures = { 3, 1, 5, 2, 4 };
            Assert.AreEqual(12, TreasureHuntSystem.MaxTreasureValue(treasures));
        }
    }
}