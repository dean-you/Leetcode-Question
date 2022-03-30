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
    public class _557ReverseWordsInAStringTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            var test = new _557ReverseWordsInAString();
            var r = test.ReverseWords("Let's take LeetCode contest");
            Assert.AreEqual("s'teL ekat edoCteeL tsetnoc", r);
        }
    }
}