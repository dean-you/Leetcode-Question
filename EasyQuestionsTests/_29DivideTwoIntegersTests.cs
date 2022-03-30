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
    public class _29DivideTwoIntegersTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            var t = new _29DivideTwoIntegers();
            var r = t.Divide(-2147483648, - 1);
            Assert.AreEqual(2147483647, r);
        }
    }
}