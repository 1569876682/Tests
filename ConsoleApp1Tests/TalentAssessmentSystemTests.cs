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
    public class TalentAssessmentSystemTests
    {
        [TestMethod()]
        public void FindMedianTalentIndexTest()
        {
            int[] fireAbility = { 1, 3, 7, 9, 11 };
            int[] iceAbility = { 2, 4, 8, 10, 12, 14 };
            Assert.AreEqual(8, TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility));
        }
    }
}