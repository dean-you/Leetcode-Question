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
    public class ChanllengerTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            var t = new Chanllenger();
            var r = t.Calculate();
            Assert.AreEqual(6, r);
        }
    }
}