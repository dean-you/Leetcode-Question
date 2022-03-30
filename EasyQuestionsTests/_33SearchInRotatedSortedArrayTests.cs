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
    public class _33SearchInRotatedSortedArrayTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] {4, 5, 6, 7, 0, 1, 2}, 0);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void SearchTest1()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            Assert.AreEqual(-1, r);
        }

        [TestMethod()]
        public void SearchTest2()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 6);
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void SearchTest3()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 1 }, 0);
            Assert.AreEqual(-1, r);
        }

        [TestMethod()]
        public void SearchTest4()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 1 }, 1);
            Assert.AreEqual(0, r);
        }

        [TestMethod()]
        public void SearchTest5()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 3,1 }, 1);
            Assert.AreEqual(1, r);
        }

        [TestMethod()]
        public void SearchTest6()
        {
            var t = new _33SearchInRotatedSortedArray();
            var r = t.Search(new int[] { 4, 5, 6, 7, 8, 1, 2, 3 }, 8);
            Assert.AreEqual(4, r);
        }
    }
}