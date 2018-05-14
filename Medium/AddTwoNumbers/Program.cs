using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int x)
        {
            this.val = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l13 = new ListNode(8);
            ListNode l12 = new ListNode(5);
            ListNode l11 = new ListNode(9);
            l12.next = l13;
            l11.next = l12;

            ListNode l23 = new ListNode(3);
            ListNode l22 = new ListNode(9);
            ListNode l21 = new ListNode(3);
            l22.next = l23;
            l21.next = l22;

            ListNode l1 = new ListNode(9);
            ListNode l2 = new ListNode(9);

            ListNode l = AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            return AddTwoNumbers(l1, l2, ref carry);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, ref int carry)
        {
            int a = 0;
            int b = 0;

            if (l1 != null)
            {
                a = l1.val;
            }
            if (l2 != null)
            {
                b = l2.val;
            }


            int sum = a + b + carry;
            carry = sum > 9 ? 1 : 0;
            sum = sum % 10;
            ListNode l = new ListNode(sum);
            if(l1.next == null && l2.next != null)
            {
                l.next = AddTwoNumbers(new ListNode(0), l2.next, ref carry);
            }
            else if(l1.next != null && l2.next == null)
            {
                l.next = AddTwoNumbers(l1.next, new ListNode(0), ref carry);
            }
            else if(l1.next != null && l2.next != null)
            {
                l.next = AddTwoNumbers(l1.next, l2.next, ref carry);
            }
            else if (l1.next == null && l2.next == null)
            {
                ListNode lastNumber = new ListNode(sum);
                if (carry > 0)
                {
                    lastNumber.next = new ListNode(1);
                }

                return lastNumber;
            }

            return l;
        }
    }
}
