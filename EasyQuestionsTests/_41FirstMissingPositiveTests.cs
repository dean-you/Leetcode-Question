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
    public class _41FirstMissingPositiveTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            var t = new _41FirstMissingPositive();
            var r = t.FirstMissingPositive(new int[] { 1, 2, 0 });
            Assert.AreEqual(3, r);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest1()
        {
            var t = new _41FirstMissingPositive();
            var r = t.FirstMissingPositive(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest2()
        {
            var t = new _41FirstMissingPositive();
            var r = t.FirstMissingPositive(new int[] { 7,8,9,11,12 });
            Assert.AreEqual(1, r);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest3()
        {
            var t = new _41FirstMissingPositive();
            var r = t.FirstMissingPositive(new int[] { 1 });
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest4()
        {
            var t = new _41FirstMissingPositive();
            var r = t.FirstMissingPositive(new int[] { 1, 2, 2, 1, 3, 1, 0, 4, 0 });
            Assert.AreEqual(5, r);
        }
    }
}