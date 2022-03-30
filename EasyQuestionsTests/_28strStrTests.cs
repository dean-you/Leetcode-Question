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
    public class _28strStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            var test = new _28strStr();
            var r = test.StrStr("hello", "ll");
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void StrStrTest1()
        {
            var test = new _28strStr();
            var r = test.StrStr("aaaaa", "bba");
            Assert.AreEqual(-1, r);
        }

        [TestMethod()]
        public void StrStrTest2()
        {
            var test = new _28strStr();
            var r = test.StrStr("", "");
            Assert.AreEqual(0, r);
        }

        [TestMethod()]
        public void StrStrTest3()
        {
            var test = new _28strStr();
            var r = test.StrStr("heaabo", "ab");
            Assert.AreEqual(3, r);
        }

        [TestMethod()]
        public void StrStrTest4()
        {
            var test = new _28strStr();
            var r = test.StrStr("heaaabo", "aab");
            Assert.AreEqual(3, r);
        }
    }
}