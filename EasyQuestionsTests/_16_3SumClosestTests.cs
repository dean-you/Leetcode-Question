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
    public class _16_3SumClosestTests
    {
        [TestMethod()]
        public void ThreeSumClosestTest()
        {
            var t = new _16_3SumClosest();
            var r = t.ThreeSumClosest(new int[]{-1,2,1,-4}, 1);
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void ThreeSumClosestTest1()
        {
            var t = new _16_3SumClosest();
            var r = t.ThreeSumClosest(new int[] { 0,0,0 }, 1);
            Assert.AreEqual(0, r);
        }

        [TestMethod()]
        public void ThreeSumClosestTest2()
        {
            var t = new _16_3SumClosest();
            var r = t.ThreeSumClosest(new int[] { 1, 2,4,8,16,32,64,128 }, 82);
            Assert.AreEqual(82, r);
        }

        [TestMethod()]
        public void ThreeSumClosestTest3()
        {
            var t = new _16_3SumClosest();
            var r = t.ThreeSumClosest(new int[] { 1, 6,9,14,16,70 }, 81);
            Assert.AreEqual(80, r);
        }
    }
}