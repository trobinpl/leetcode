using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            int r2 = MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            int r3 = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }

        public static int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for(int i=1; i<prices.Length; i++)
            {
                maxprofit += Math.Max(0, prices[i] - prices[i - 1]);
            }
            return maxprofit;
        }
    }
}
