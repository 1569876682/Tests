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
    public class EnergyFieldSystemTests
    {
        [TestMethod()]
        public void MaxEnergyFieldTest()
        {
            int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Assert.AreEqual(52.5, EnergyFieldSystem.MaxEnergyField(heights));
        }
    }
}