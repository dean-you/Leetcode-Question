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
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var test = new ReverseInteger();
            var r = test.Reverse(123);
            Assert.AreEqual(321, r);
        }
    }
}