using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LeaderboardSystemTests
    {
        [TestMethod()]
        public void GetTopScoresTest()
        {
            int[] scores = { 99, 100, 34, 50, 102, 70, 30, 20, 10 };
            int m = 3;
            List<int> expected = new List<int> { 102, 100, 99 };
            List<int> result = LeaderboardSystem.GetTopScores(scores, m);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}