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
    public class _31NextPermutationTests
    {
        [TestMethod()]
        public void NextPermutationTest()
        {
            var t = new _31NextPermutation();
            var r = t.NextPermutation(new int[] {1, 2, 3});
            Assert.AreEqual(r[0], 1);
            Assert.AreEqual(r[1], 3);
            Assert.AreEqual(r[2], 2);
        }

        [TestMethod()]
        public void NextPermutationTest1()
        {
            var t = new _31NextPermutation();
            var r = t.NextPermutation(new int[] { 3, 2, 1 });
            Assert.AreEqual(r[0], 1);
            Assert.AreEqual(r[1], 2);
            Assert.AreEqual(r[2], 3);
        }

        [TestMethod()]
        public void NextPermutationTest2()
        {
            var t = new _31NextPermutation();
            var r = t.NextPermutation(new int[] { 1, 1, 5 });
            Assert.AreEqual(r[0], 1);
            Assert.AreEqual(r[1], 5);
            Assert.AreEqual(r[2], 1);
        }

        [TestMethod()]
        public void NextPermutationTest3()
        {
            var t = new _31NextPermutation();
            var r = t.NextPermutation(new int[] { 1, 2 });
            Assert.AreEqual(r[0], 2);
            Assert.AreEqual(r[1], 1);
        }
        [TestMethod()]
        public void NextPermutationTest4()
        {
            var t = new _31NextPermutation();
            var r = t.NextPermutation(new int[] { 2, 3, 1 });
            Assert.AreEqual(r[0], 3);
            Assert.AreEqual(r[1], 1);
            Assert.AreEqual(r[2], 2);
        }

    }
}