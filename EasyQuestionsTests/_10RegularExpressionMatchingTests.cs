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
    public class _10RegularExpressionMatchingTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            var t = new _10RegularExpressionMatching();
            var r = t.IsMatch("aa", "a");
            Assert.AreEqual(false, r);
        }

        [TestMethod()]
        public void IsMatchTest1()
        {
            var t = new _10RegularExpressionMatching();
            var r = t.IsMatch("aa", "a.");
            Assert.AreEqual(true, r);
        }

        [TestMethod()]
        public void IsMatchTest2()
        {
            var t = new _10RegularExpressionMatching();
            var r = t.IsMatch("aa", ".*");
            Assert.AreEqual(true, r);
        }

        [TestMethod()]
        public void IsMatchTest3()
        {
            var t = new _10RegularExpressionMatching();
            var r = t.IsMatch("aaa", ".*");
            Assert.AreEqual(true, r);
        }

        [TestMethod()]
        public void IsMatchTest4()
        {
            var t = new _10RegularExpressionMatching();
            var r = t.IsMatch("aaa", "a*");
            Assert.AreEqual(true, r);
        }
    }
}