using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EasyQuestions
{
    class _19RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var slow = head;
            var fast = head;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            while (fast != null && fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            if (slow.next != null)
            {
                if ((slow == head && fast == null))
                    head = head.next;
                else
                    slow.next = slow.next.next;
            }
            else
            {
                head = null;
            }
            return head;
        }

        public ListNode RemoveNthFromEnd1(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;
            // Advances first pointer so that the gap between first and second is n nodes apart
            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }
            // Move first to the end, maintaining the gap
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;
        }
    }
}
