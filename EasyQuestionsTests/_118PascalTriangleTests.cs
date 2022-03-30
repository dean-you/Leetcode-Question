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
    public class _118PascalTriangleTests
    {
        [TestMethod()]
        public void GenerateTest()
        {
            var t = new _118PascalTriangle();
            var r = t.Generate(1);
            Assert.AreEqual(1, r.Count);
            Assert.AreEqual(1, r[0].Count);
            Assert.AreEqual(1, r[0][0]);
        }

        [TestMethod()]
        public void GenerateTest1()
        {
            var t = new _118PascalTriangle();
            var r = t.Generate(2);
            Assert.AreEqual(2, r.Count);
            Assert.AreEqual(1, r[1][0]);
            Assert.AreEqual(1, r[1][1]);
        }

        [TestMethod()]
        public void GenerateTest2()
        {
            var t = new _118PascalTriangle();
            var r = t.Generate(3);
            Assert.AreEqual(3, r.Count);
            Assert.AreEqual(1, r[2][0]);
            Assert.AreEqual(2, r[2][1]);
            Assert.AreEqual(1, r[2][2]);
        }

        [TestMethod()]
        public void GenerateTest3()
        {
            var t = new _118PascalTriangle();
            var r = t.Generate(4);
            Assert.AreEqual(4, r.Count);
            Assert.AreEqual(1, r[3][0]);
            Assert.AreEqual(3, r[3][1]);
            Assert.AreEqual(3, r[3][2]);
            Assert.AreEqual(1, r[3][3]);
        }
    }
}