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
    public class _994RottingOrangesTests
    {
        [TestMethod()]
        public void OrangesRottingTest()
        {
            var t = new _994RottingOranges();
            var grid = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                grid[i] = new int[3];
            }
            grid[0][0] = 2;
            grid[0][1] = 1;
            grid[0][2] = 1;
            grid[1][0] = 1;
            grid[1][1] = 1;
            grid[1][2] = 0;
            grid[2][0] = 0;
            grid[2][1] = 1;
            grid[2][2] = 1;
            var r = t.OrangesRotting(grid);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void OrangesRottingTest1()
        {
            var t = new _994RottingOranges();
            var grid = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                grid[i] = new int[3];
            }
            grid[0][0] = 2;
            grid[0][1] = 1;
            grid[0][2] = 1;
            grid[1][0] = 0;
            grid[1][1] = 1;
            grid[1][2] = 1;
            grid[2][0] = 1;
            grid[2][1] = 0;
            grid[2][2] = 1;
            var r = t.OrangesRotting(grid);
            Assert.AreEqual(-1, r);
        }

        [TestMethod()]
        public void OrangesRottingTest2()
        {
            var t = new _994RottingOranges();
            var grid = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                grid[i] = new int[1];
            }
            grid[0][0] = 2;
            grid[1][0] = 1;
            var r = t.OrangesRotting(grid);
            Assert.AreEqual(1, r);
        }
    }
}