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
    public class _69SqrtTests
    {
        [TestMethod()]
        public void MySqrtTest()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(4);
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void MySqrtTest1()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(8);
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void MySqrtTest2()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(99);
            Assert.AreEqual(9, r);
        }

        [TestMethod()]
        public void MySqrtTest3()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(100);
            Assert.AreEqual(10, r);
        }

        [TestMethod()]
        public void MySqrtTest4()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(101);
            Assert.AreEqual(10, r);
        }

        [TestMethod()]
        public void MySqrtTest5()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(1);
            Assert.AreEqual(1, r);
        }

        [TestMethod()]
        public void MySqrtTest6()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(0);
            Assert.AreEqual(0, r);
        }

        [TestMethod()]
        public void MySqrtTest7()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(2147395599);
            Assert.AreEqual(46339, r);
        }

        [TestMethod()]
        public void MySqrtTest8()
        {
            var test = new _69Sqrt();
            var r = test.MySqrt(2147483647);
            Assert.AreEqual(46340, r);
        }
    }
}