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
    public class _39CombinationSumTests
    {
        [TestMethod()]
        public void CombinationSumTest()
        {
            var t = new _39CombinationSum();
            var r = t.CombinationSum(new int[] { 2, 3, 4 }, 6);
            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2 }, r[0].ToList());
            CollectionAssert.AreEqual(new List<int>() { 2, 4 }, r[1].ToList());
            CollectionAssert.AreEqual(new List<int>() { 3, 3 }, r[2].ToList());
        }
    }
}