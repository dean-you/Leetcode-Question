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
    public class _67AddBinaryTests
    {
        [TestMethod()]
        public void AddBinaryTest()
        {
            var test = new _67AddBinary();
            var r = test.AddBinary("11", "1");
            Assert.AreEqual("100", r);
        }

        [TestMethod()]
        public void AddBinaryTest1()
        {
            var test = new _67AddBinary();
            var r = test.AddBinary("1010", "1011");
            Assert.AreEqual("10101", r);
        }

        [TestMethod()]
        public void AddBinaryTest2()
        {
            var test = new _67AddBinary();
            var r = test.AddBinary("", "");
            Assert.AreEqual("", r);
        }

        [TestMethod()]
        public void AddBinaryTest3()
        {
            var test = new _67AddBinary();
            var r = test.AddBinary("100", "110010");
            Assert.AreEqual("110110", r);
        }
    }
}