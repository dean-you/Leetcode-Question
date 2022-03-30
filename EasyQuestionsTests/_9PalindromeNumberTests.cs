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
    public class _9PalindromeNumberTests
    {
        [TestMethod()]
        public void IsPalindromeTest_GivenNagetive_ShallReturnFalse()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(-1);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_Given0_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(0);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenPalindromeOddNumber_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(121);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenPalindromeOddNumber1_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(12321);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenPalindromeEvenNumber_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(1221);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenPalindromeEvenNumber1_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(123321);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenNotPalindromeOddNumber_ShallReturnFalse()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(122);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenNotPalindromeEvenNumber_ShallReturnFalse()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(1222);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenNotPalindromeLastDigit0_ShallReturnFalse()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(10);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsPalindromeTest_GivenPalindrome1_ShallReturnTrue()
        {
            var test = new _9PalindromeNumber();
            var result = test.IsPalindrome(1);
            Assert.AreEqual(true, result);
        }
    }
}