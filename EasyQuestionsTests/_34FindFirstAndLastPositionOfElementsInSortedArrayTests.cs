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
    public class _34FindFirstAndLastPositionOfElementsInSortedArrayTests
    {
        [TestMethod()]
        public void SearchRangeTest()
        {
            var t = new _34FindFirstAndLastPositionOfElementsInSortedArray();
            var r = t.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            Assert.AreEqual(3, r[0]);
            Assert.AreEqual(4, r[1]);
        }

        [TestMethod()]
        public void SearchRangeTest1()
        {
            var t = new _34FindFirstAndLastPositionOfElementsInSortedArray();
            var r = t.SearchRange(new int[] { 1 }, 1);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(0, r[1]);
        }

        [TestMethod()]
        public void SearchRangeTest2()
        {
            var t = new _34FindFirstAndLastPositionOfElementsInSortedArray();
            var r = t.SearchRange(new int[] { 1, 3 }, 1);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(0, r[1]);
        }

        [TestMethod()]
        public void SearchRangeTest3()
        {
            var t = new _34FindFirstAndLastPositionOfElementsInSortedArray();
            var r = t.SearchRange(new int[] { 3, 3, 3 }, 3);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(2, r[1]);
        }
    }
}