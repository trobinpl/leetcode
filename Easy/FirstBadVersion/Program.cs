using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int FirstBadVersion(int n)
        {
            if (IsBadVersion(1))
            {
                return 1;
            }
            int min = 1;
            int max = n;
            int middle = 0;
            while (min <= max)
            {
                middle = min + (max - min) / 2;
                if (IsBadVersion(middle))
                {
                    if (middle == 1 || !IsBadVersion(middle - 1))
                    {
                        return middle;
                    }
                    else
                    {
                        max = middle - 1;
                    }

                }
                else
                {
                    min = middle + 1;
                }

            }
            return max;
        }

        static bool IsBadVersion(int n)
        {
            // It's dummy implementation
            /*
             * 1 2 3 4 5 6 7 8 9
             * F F F F T T T T T <- this should return IsBadVersion
             */
            return true;
        }
    }
}
