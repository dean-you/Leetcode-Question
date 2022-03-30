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
    public class _38CountAndSayTests
    {
        [TestMethod()]
        public void CountAndSayTest()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(1);
            Assert.AreEqual("1", r);
        }

        [TestMethod()]
        public void CountAndSayTest2()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(2);
            Assert.AreEqual("11", r);
        }

        [TestMethod()]
        public void CountAndSayTest3()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(3);
            Assert.AreEqual("21", r);
        }

        [TestMethod()]
        public void CountAndSayTest4()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(4);
            Assert.AreEqual("1211", r);
        }

        [TestMethod()]
        public void CountAndSayTest5()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(5);
            Assert.AreEqual("111221", r);
        }

        [TestMethod()]
        public void CountAndSayTest6()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(6);
            Assert.AreEqual("312211", r);
        }

        [TestMethod()]
        public void CountAndSayTest7()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(7);
            Assert.AreEqual("13112221", r);
        }

        [TestMethod()]
        public void CountAndSayTest8()
        {
            var t = new _38CountAndSay();
            var r = t.CountAndSay(8);
            Assert.AreEqual("1113213211", r);
        }
    }
}