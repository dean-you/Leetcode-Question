using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _876MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            while (fast != null)
            {
                fast = fast.next;
                if (fast != null)
                    fast = fast.next;
                else
                {
                    break;
                }
                head = head.next;
            }
            return head;
        }
    }
}
