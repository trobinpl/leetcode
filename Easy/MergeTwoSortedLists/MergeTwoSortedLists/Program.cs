using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    class Program
    {
        /*
         * Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
         * 1->2->4, 1->3->4; result: 1->1->2->3->4->4
         */
        static void Main(string[] args)
        {
            ListNode l11 = new ListNode(1);
            ListNode l12 = new ListNode(2);
            ListNode l13 = new ListNode(4);
            l11.next = l12;
            l12.next = l13;

            ListNode l21 = new ListNode(1);
            ListNode l22 = new ListNode(3);
            ListNode l23 = new ListNode(4);
            l21.next = l22;
            l22.next = l23;

            ListNode merged = MergeTwoLists(l11, l21);

        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if(l1 == null && l2 == null)
            {
                return null;
            }

            ListNode newHead = null;

            if(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    newHead = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    newHead = new ListNode(l2.val);
                    l2 = l2.next;
                }
            }
            else if(l1 == null)
            {
                newHead = new ListNode(l2.val);
                l2 = l2.next;
            }
            else if(l2 == null)
            {
                newHead = new ListNode(l1.val);
                l1 = l1.next;
            }
            
            newHead.next = Merge(l1, l2, newHead);
            return newHead;
        }

        static ListNode Merge(ListNode l1, ListNode l2, ListNode current)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current = new ListNode(l1.val);
                    l1 = l1.next;
                    current.next = Merge(l1, l2, current);
                }
                else
                {
                    current = new ListNode(l2.val);
                    l2 = l2.next;
                    current.next = Merge(l1, l2, current);
                }
            }
            else if (l1 == null)
            {
                current = new ListNode(l2.val);
                l2 = l2.next;
                current.next = Merge(l1, l2, current);
            }
            else if (l2 == null)
            {
                current = new ListNode(l1.val);
                l1 = l1.next;
                current.next = Merge(l1, l2, current);
            }

            return current;
        }
    }

    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int x) { val = x; }
    }
}
