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
    public class _542MatrixTests
    {
        [TestMethod()]
        public void UpdateMatrixTest()
        {
            var t = new _542Matrix();
            var mat = new int [3][];
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new int[3];
            }
            mat[0][0] = 0;
            mat[0][1] = 0;
            mat[0][2] = 0;
            mat[1][0] = 0;
            mat[1][1] = 1;
            mat[1][2] = 0;
            mat[2][0] = 1;
            mat[2][1] = 1;
            mat[2][2] = 1;
            var r = t.UpdateMatrix(mat);
            Assert.AreEqual(r[0][0], 0);
            Assert.AreEqual(r[0][1], 0);
            Assert.AreEqual(r[0][2], 0);
            Assert.AreEqual(r[1][0], 0);
            Assert.AreEqual(r[1][1], 1);
            Assert.AreEqual(r[1][2], 0);
            Assert.AreEqual(r[2][0], 1);
            Assert.AreEqual(r[2][1], 2);
            Assert.AreEqual(r[2][2], 1);
        }
    }
}