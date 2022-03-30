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
    public class _24SwapNodesInPairsTests
    {
        [TestMethod()]
        public void SwapPairsTest()
        {
            var t = new _24SwapNodesInPairs();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var r = t.SwapPairs(head);
            Assert.AreEqual(2, r.val);
            Assert.AreEqual(1, r.next.val);
            Assert.AreEqual(4, r.next.next.val);
            Assert.AreEqual(3, r.next.next.next.val);
            Assert.AreEqual(null, r.next.next.next.next);
        }
    }
}