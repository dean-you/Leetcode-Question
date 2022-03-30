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
    public class _6ZigzagConversionTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            var t = new _6ZigzagConversion();
            var r = t.Convert("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", r);
        }
    }
}