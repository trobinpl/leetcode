using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l5 = new ListNode(5);
            ListNode l4 = new ListNode(4);
            ListNode l3 = new ListNode(3);
            ListNode l2 = new ListNode(2);
            ListNode l1 = new ListNode(1);

            l4.next = l5;
            l3.next = l4;
            l2.next = l3;
            l1.next = l2;

            ListNode l21 = new ListNode(1);

            ListNode l32 = new ListNode(2);
            ListNode l31 = new ListNode(1);
            l31.next = l32;

            ListNode r = ReverseList(l1);
            ListNode r2 = ReverseList(l21);
            ListNode r3 = ReverseList(null);
            ListNode r4 = ReverseList(l31);
        }

        static ListNode ReverseList(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return p;
        }

        static ListNode GetLastNode(ListNode head)
        {
            ListNode lastNode = head;
            ListNode previous = null;
            while(head != null)
            {
                previous = lastNode;
                lastNode = head;
                head = head.next;
            }

            previous.next = null;

            return lastNode;
        }
    }
}
