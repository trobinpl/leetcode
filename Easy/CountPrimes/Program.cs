using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = CountPrimes(10);
        }

        public static int CountPrimes(int n)
        {
            List<bool> primes = new List<bool>(n);
            for(int i = 2; i<Math.Floor(Math.Sqrt(n)); i++)
            {

            }
            return 0;
        }
    }
}
