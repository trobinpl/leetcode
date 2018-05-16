using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangleII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> r = GetRow(3);
        }

        public static List<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
            {
                return new List<int> { 1 };
            }
            if (rowIndex == 1)
            {
                return new List<int> { 1, 1 };
            }

            List<int> previousRow = GetRow(rowIndex - 1).ToList();
            List<int> currentRow = new List<int>() { 1 };

            for (int i = 1; i < previousRow.Count; i++)
            {
                int sum = previousRow[i - 1] + previousRow[i];
                currentRow.Add(sum);
            }

            currentRow.Add(1);

            return currentRow;
        }
    }
}
