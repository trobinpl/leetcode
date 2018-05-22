using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MySqt(4);
            int r2 = MySqt(8);
        }

        static int MySqt(int x)
        {
            int i = 0;
            while(x > 0)
            {
                i++;
                x = x >> 1;
            }
            return i;
        }
    }
}
