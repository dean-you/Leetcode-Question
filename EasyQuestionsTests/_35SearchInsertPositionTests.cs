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
    public class _35SearchInsertPositionTests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            var test = new _35SearchInsertPosition();
            var r = test.SearchInsert(new int[] {1, 3, 5, 6}, 5);
            Assert.AreEqual(2, r);
        }

        [TestMethod()]
        public void SearchInsertTest1()
        {
            var test = new _35SearchInsertPosition();
            var r = test.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.AreEqual(1, r);
        }

        [TestMethod()]
        public void SearchInsertTest2()
        {
            var test = new _35SearchInsertPosition();
            var r = test.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void SearchInsertTest3()
        {
            var test = new _35SearchInsertPosition();
            var r = test.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Assert.AreEqual(0, r);
        }

        [TestMethod()]
        public void SearchInsertTest4()
        {
            var test = new _35SearchInsertPosition();
            var r = test.SearchInsert(new int[] { 1}, 0);
            Assert.AreEqual(0, r);
        }
    }
}