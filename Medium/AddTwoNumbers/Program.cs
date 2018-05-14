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
            ListNode l12 = new ListNode(5);
            ListNode l11 = new ListNode(9);
            l11.next = l12;

            ListNode l23 = new ListNode(3);
            ListNode l22 = new ListNode(9);
            ListNode l21 = new ListNode(3);
            l22.next = l23;
            l21.next = l22;

            ListNode l = AddTwoNumbers(l11, l21);
            //int sum = l11.val + l21.val;
            //int carry = sum > 9 ? 1 : 0;
            //ListNode l = new ListNode(sum % 10);
            //l.next = AddTwoNumbers(l11.next, l21.next, ref carry);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = l1.val + l2.val;
            int carry = sum > 9 ? 1 : 0;
            ListNode l = new ListNode(sum % 10);
            l.next = AddTwoNumbers(l1.next, l2.next, ref carry);

            return l;
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
            if(l1 == null && l2 != null)
            {
                l.next = AddTwoNumbers(null, l2.next, ref carry);
            }
            else if(l1 != null && l2 == null)
            {
                l.next = AddTwoNumbers(l1.next, null, ref carry);
            }
            else if(l1 != null && l2 != null)
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

            //int sum = 0;
            //int carry = 0;

            //while(l1.next != null && l2.next != null)
            //{
            //    int a = 0;
            //    int b = 0;

            //    if(l1 != null)
            //    {
            //        a = l1.val;
            //    }
            //    if(l2 != null)
            //    {
            //        b = l2.val;
            //    }

            //   sum = sum + Sum(l1, l2, out carry);
            //}
        }

        static int Sum(ListNode a, ListNode b, out int carry)
        {
            int sum = a.val + b.val;
            carry = sum > 9 ? 1 : 0;
            sum = sum + carry;
            return sum % 10;
        }
    }
}
