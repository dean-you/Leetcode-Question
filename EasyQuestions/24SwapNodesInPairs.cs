using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _24SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            var cur = head.next;
            var prev = head;
            head = cur;
            while (cur!= null)
            {
                var next = cur.next;
                cur.next = prev;
                if (next == null)
                {
                    prev.next = null;
                    break;
                }
                else
                {
                    var nextnext = next.next;
                    if (nextnext == null)
                    {
                        prev.next = next;
                    }
                    else
                    {
                        prev.next = nextnext;
                    }
                    cur = nextnext;
                    prev = next;
                }
            }
            return head;
        }
    }
}
