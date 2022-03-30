using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions.Tests
{
    [TestClass()]
    public class _15_3SumTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            var t = new _15_3Sum();
            var nums = new int[] {-1, 0, 1, 2, -1, -4};
            var r = t.ThreeSum(nums);
            Assert.AreEqual(2, r.Count);
        }
    }
}