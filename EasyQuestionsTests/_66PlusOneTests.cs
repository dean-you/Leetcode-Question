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
    public class _66PlusOneTests
    {
        [TestMethod()]
        public void PlusOneTest()
        {
            var test = new _66PlusOne();
            var r = test.PlusOne(new int[] {1, 2, 3});
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(2, r[1]);
            Assert.AreEqual(4, r[2]);
        }

        [TestMethod()]
        public void PlusOneTest2()
        {
            var test = new _66PlusOne();
            var r = test.PlusOne(new int[] { 0 });
            Assert.AreEqual(1, r.Length);
            Assert.AreEqual(1, r[0]);
        }

        [TestMethod()]
        public void PlusOneTest3()
        {
            var test = new _66PlusOne();
            var r = test.PlusOne(new int[] {9 });
            Assert.AreEqual(1, r[0]);
            Assert.AreEqual(0, r[1]);
        }
    }
}