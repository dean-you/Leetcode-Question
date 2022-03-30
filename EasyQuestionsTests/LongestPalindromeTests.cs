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
    public class LongestPalindromeTests
    {
        [TestMethod()]
        public void LongestPalindrome2Test()
        {
            var t = new LongestPalindrome();
            var r =t.LongestPalindrome2("cbbd");
            Assert.AreEqual("bb", r);
        }

        [TestMethod()]
        public void LongestPalindrome3Test()
        {
            var t = new LongestPalindrome();
            var r = t.LongestPalindrome2("ccd");
            Assert.AreEqual("cc", r);
        }
    }
}