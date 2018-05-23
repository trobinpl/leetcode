using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveLinkedListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l7 = new ListNode(6);
            ListNode l6 = new ListNode(5);
            ListNode l5 = new ListNode(4);
            ListNode l4 = new ListNode(3);
            ListNode l3 = new ListNode(6);
            ListNode l2 = new ListNode(2);
            ListNode l1 = new ListNode(6);
            l6.next = l7;
            l5.next = l6;
            l4.next = l5;
            l3.next = l4;
            l2.next = l3;
            l1.next = l2;

            ListNode l24 = new ListNode(5);
            ListNode l23 = new ListNode(6);
            ListNode l22 = new ListNode(6);
            ListNode l21 = new ListNode(6);
            l23.next = l24;
            l22.next = l23;
            l21.next = l22;

            ListNode l34 = new ListNode(1);
            ListNode l33 = new ListNode(2);
            ListNode l32 = new ListNode(2);
            ListNode l31 = new ListNode(1);
            l33.next = l34;
            l32.next = l33;
            l31.next = l32;

            //ListNode r = RemoveElement(l1, 6);
            ListNode r2 = RemoveElement(null, 1);
            //ListNode r3 = RemoveElement(l21, 6);
            ListNode r4 = RemoveElement(l31, 2);
        }

        static ListNode RemoveElement(ListNode head, int val)
        {
            if(head == null)
            {
                return null;
            }

            ListNode pointer = head;
            while(pointer.next != null)
            {
                if(pointer.next.val == val)
                {
                    pointer.next = pointer.next.next;
                }
                else
                {
                    pointer = pointer.next;
                }
            }

            return head.val == val ? head.next : head;
        }
    }
}
