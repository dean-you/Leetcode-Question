using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyQuestions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions.Tests
{
    [TestClass()]
    public class _26RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var test = new _26RemoveDuplicatesFromSortedArray();
            var nums = new int[] {1, 1, 2};
            var result = test.RemoveDuplicates(nums);
            int[] expectedNums = new int[] {1, 2};
            Assert.AreEqual(2, result);
            for (int i = 0; i < result; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i] );
            }
        }

        [TestMethod()]
        public void RemoveDuplicatesTest1()
        {
            var test = new _26RemoveDuplicatesFromSortedArray();
            var nums = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            var result = test.RemoveDuplicates(nums);
            int[] expectedNums = new int[] {0, 1, 2, 3, 4};
            Assert.AreEqual(5, result);
            for (int i = 0; i < result; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        [TestMethod()]
        public void RemoveDuplicates1Test()
        {
            var test = new _26RemoveDuplicatesFromSortedArray();
            var nums = new int[] { 1, 1, 2 };
            var result = test.RemoveDuplicates1(nums);
            int[] expectedNums = new int[] { 1, 2 };
            Assert.AreEqual(2, result);
            for (int i = 0; i < result; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

        [TestMethod()]
        public void RemoveDuplicates1Test1()
        {
            var test = new _26RemoveDuplicatesFromSortedArray();
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = test.RemoveDuplicates1(nums);
            int[] expectedNums = new int[] { 0, 1, 2, 3, 4 };
            Assert.AreEqual(5, result);
            for (int i = 0; i < result; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }
    }
}