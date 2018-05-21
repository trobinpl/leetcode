using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedList
{
    class Program
    {
        /*
         * Given a sorted linked list, delete all duplicates such that each element appear only once.
         * 1->1->2 --> 1->2
         * 1->1->2->3->3 --> 1->2->3
         */
        static void Main(string[] args)
        {
            ListNode l5 = new ListNode(3);
            ListNode l4 = new ListNode(3);
            ListNode l3 = new ListNode(2);
            ListNode l2 = new ListNode(1);
            ListNode l1 = new ListNode(1);
            l4.next = l5;
            l3.next = l4;
            l2.next = l3;
            l1.next = l2;

            ListNode r = DeleteDuplicates(l1);
        }

        static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while(current != null && current.next != null)
            {
                if(current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
    }
}
