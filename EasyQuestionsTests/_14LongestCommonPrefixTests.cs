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
    public class _14LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            var test = new _14LongestCommonPrefix();
            var result = test.LongestCommonPrefix(new String[]{ "flower", "flow", "flight" });
            Assert.AreEqual("fl", result);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest1()
        {
            var test = new _14LongestCommonPrefix();
            var result = test.LongestCommonPrefix(new String[] { "dog", "racecar", "car" });
            Assert.AreEqual("", result);
        }
    }
}