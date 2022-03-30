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
    public class _13RomanToIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            var test = new _13RomanToInteger();

            var result = test.RomanToInt("III");

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void RomanToIntTest1()
        {
            var test = new _13RomanToInteger();

            var result = test.RomanToInt("IV");

            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void RomanToIntTest2()
        {
            var test = new _13RomanToInteger();

            var result = test.RomanToInt("IX");

            Assert.AreEqual(9, result);
        }

        [TestMethod()]
        public void RomanToIntTest3()
        {
            var test = new _13RomanToInteger();

            var result = test.RomanToInt("LVIII");

            Assert.AreEqual(58, result);
        }

        [TestMethod()]
        public void RomanToIntTest4()
        {
            var test = new _13RomanToInteger();

            var result = test.RomanToInt("MCMXCIV");

            Assert.AreEqual(1994, result);
        }
    }
}