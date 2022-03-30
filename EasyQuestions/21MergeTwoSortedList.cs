using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class _21MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var sL1 = new ListNode();
            var eL1 = new ListNode();
            while (l2.next != null)
            {
                while (l1.next != null)
                {
                    if (l1.val < l2.val)
                    {
                        eL1 = l1;
                        l1 = l1.next;
                    }
                    else if (l1.val <= l2.next.val)
                    {
                        if (eL1.next != null)
                        {
                            eL1.next = l2;
                            sL1 = l1;
                        }
                        eL1 = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        eL1.next = l2.next;
                        l2.next = sL1;
                        l2 = eL1.next;
                    }
                }
            }
            return l2;
        }
    }
}
