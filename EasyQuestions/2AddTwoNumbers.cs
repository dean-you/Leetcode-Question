using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            var temp = 0;
            while (l1 != null || l2 != null)
            {
                result.val += temp;

                if (l1 != null)
                {
                    result.val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    result.val += l2.val;
                    l2 = l2.next;
                }

                temp = result.val / 10;
                result.val = result.val % 10;
                if (l1 != null || l2 != null || temp > 0)
                {
                    result.next = new ListNode();
                    result = result.next;
                }
            }

            if (temp > 0)
                result.val = temp;
            return head;
        }
    }
}
