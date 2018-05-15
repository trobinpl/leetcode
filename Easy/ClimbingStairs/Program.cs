using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    class Program
    {
        /*
         * You are climbing a stair case. It takes n steps to reach to the top.

           Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

           Note: Given n will be a positive integer.

            2 -> 2 (1+1; 2)
            3 -> 3 (1+1+1, 1+2. 2+1)
        */
        static void Main(string[] args)
        {
            //int r = AllPossibleWays(2);
            //int r2 = AllPossibleWays(3);
            int r3 = ClimbStairs(4);
            int r4 = ClimbStairs(5);
            int r5 = ClimbStairs(6);
        }

        static int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int[] ways = new int[n + 1];
            ways[1] = 1;
            ways[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[n];
        }
    }
}
