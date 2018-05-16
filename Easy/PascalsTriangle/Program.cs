using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> r = Generate(5);
            List<int> r2 = GenerateRow(3);
        }

        public static List<List<int>> Generate(int numRows)
        {
            List<List<int>> result = new List<List<int>>();
            for(int i = 1; i<=numRows; i++)
            {
                result.Add(GenerateRow(i));
            }

            return result;
        }

        public static List<int> GenerateRow(int n)
        {
            if(n == 1)
            {
                return new List<int> { 1 };
            }
            if(n == 2)
            {
                return new List<int> { 1, 1 };
            }

            List<int> previousRow = GenerateRow(n - 1).ToList();
            List<int> currentRow = new List<int>() { 1 };

            for(int i = 1; i<previousRow.Count; i++)
            {
                int sum = previousRow[i - 1] + previousRow[i];
                currentRow.Add(sum);
            }

            currentRow.Add(1);

            return currentRow;
        }
    }
}
