using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode c3 = new ListNode(3);
            ListNode c2 = new ListNode(2);
            ListNode c1 = new ListNode(1);
            c2.next = c3;
            c1.next = c2;

            ListNode a1 = new ListNode(1);
            a1.next = c1;

            ListNode b6 = new ListNode(6);
            ListNode b5 = new ListNode(5);
            ListNode b4 = new ListNode(4);
            ListNode b3 = new ListNode(3);
            ListNode b2 = new ListNode(2);
            ListNode b1 = new ListNode(1);

            b6.next = c1;
            b5.next = b6;
            b4.next = b5;
            b3.next = b4;
            b2.next = b3;
            b1.next = b2;

            ListNode r = GetIntersectionNodeMyWay(a1, b1);

            a1.next = c1;
            b1.next = c1;

            ListNode r2 = GetIntersectionNodeMyWay(a1, b1);

            ListNode x2 = new ListNode(10);
            ListNode x1 = new ListNode(9);
            x1.next = x2;

            ListNode y2 = new ListNode(20);
            ListNode y1 = new ListNode(19);
            y1.next = y2;

            ListNode r3 = GetIntersectionNode(x1, y1);
        }

        static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA == null || headB == null)
            {
                return null;
            }

            ListNode pA = headA;
            ListNode pB = headB;

            while(pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }

            return pA;
        }

        static ListNode GetIntersectionNodeMyWay(ListNode headA, ListNode headB)
        {
            int aLength = ListLength(headA);
            int bLength = ListLength(headB);
            int skipes = Math.Abs(aLength - bLength);
            ListNode aPointer = headA;
            ListNode bPointer = headB;

            if(aLength == bLength)
            {
                Intersection(aPointer, bPointer, aLength);
            }

            if(aLength > bLength)
            {
                for(int i = 0; i < skipes; i++)
                {
                    aPointer = aPointer.next;
                }
            }

            if (aLength < bLength)
            {
                for (int i = 0; i < skipes; i++)
                {
                    bPointer = bPointer.next;
                }
            }


            return Intersection(aPointer, bPointer, aLength);
        }

        static int ListLength(ListNode list)
        {
            int length = 0;
            while (list != null)
            {
                length++;
                list = list.next;
            }
            return length;
        }

        static ListNode Intersection(ListNode a, ListNode b, int length)
        {
            for(int i=0; i<length; i++)
            {
                if(a == b)
                {
                    return a;
                }
                a = a.next;
                b = b.next;
            }

            return null;
        }
    }
}
