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
    public class _3LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            var test = new _3LongestSubstringWithoutRepeatingCharacters();
            var r = test.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, r);
        }
    }
}