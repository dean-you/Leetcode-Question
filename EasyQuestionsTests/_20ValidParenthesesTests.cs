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
    public class _20ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("()");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest1()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("()[]{}");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("(]");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("([)]");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidTest4()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("{[]}");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest5()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid("{{}[][[[]]]}");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("()");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest1_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("()[]{}");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest2_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("(]");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidTest3_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("([)]");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsValidTest4_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("{[]}");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsValidTest5_Stack()
        {
            var test = new _20ValidParentheses();
            var result = test.IsValid_Stack("{{}[][[[]]]}");
            Assert.AreEqual(true, result);
        }
    }
}