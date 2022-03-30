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
    public class _189RotateArrayTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            var t = new _189RotateArray();

            var r = t.Rotate(new int[] { 1, 2 }, 3);

            Assert.AreEqual(2, r[0]);
            Assert.AreEqual(1, r[1]);
        }

        [TestMethod()]
        public void Rotate1Test()
        {
            var t = new _189RotateArray();

            var r = t.Rotate1(new int[] { 1, 2, 3,4,5,6,7 }, 3);

            Assert.AreEqual(5, r[0]);
            Assert.AreEqual(6, r[1]);
            Assert.AreEqual(7, r[2]);
            Assert.AreEqual(1, r[3]);
            Assert.AreEqual(2, r[4]);
            Assert.AreEqual(3, r[5]);
            Assert.AreEqual(4, r[6]);
        }
    }
}