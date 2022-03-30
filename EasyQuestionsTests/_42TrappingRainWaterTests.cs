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
    public class _42TrappingRainWaterTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            var t = new _42TrappingRainWater();
            var r = t.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Assert.AreEqual(6, r);
        }

        [TestMethod()]
        public void TrapTest1()
        {
            var t = new _42TrappingRainWater();
            var r = t.Trap(new int[] { 4, 2, 0, 3, 2, 5 });
            Assert.AreEqual(9, r);
        }

        [TestMethod()]
        public void Trap_StackTest()
        {
            var t = new _42TrappingRainWater();
            var r = t.Trap_Stack(new int[] { 4, 2, 0, 3, 2, 5 });
            Assert.AreEqual(9, r);
        }

        [TestMethod()]
        public void Trap_TwoPointersTest()
        {
            var t = new _42TrappingRainWater();
            var r = t.Trap_TwoPointers(new int[] { 4, 2, 0, 3, 2, 5 });
            Assert.AreEqual(9, r);
        }
    }
}