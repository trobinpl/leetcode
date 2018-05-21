using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l3;

            bool r = HasCycle(l1);
        }

        static bool HasCycle(ListNode head)
        {
            if(head == null)
            {
                return false;
            }
            ListNode current = head;
            ListNode next = head.next;
            while(current != next)
            {
                if(next == null || next.next == null)
                {
                    return false;
                }
                current = current.next;
                next = next.next.next;
            }

            return true;
        }
    }
}
