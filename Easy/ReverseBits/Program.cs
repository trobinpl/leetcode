using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint r = ReverseBits(43261596);
            uint r2 = ReverseBits(4);
        }

        public static uint ReverseBits(uint n)
        {
            BitArray bits = new BitArray(BitConverter.GetBytes(n));
            BitArray resultBits = new BitArray(bits.Length);
            for(int i = 0; i < bits.Length; i++)
            {
                resultBits[bits.Length - 1 - i] = bits[i];
            }

            var result = new int[1];
            resultBits.CopyTo(result, 0);
            return (uint)result[0];
        }
    }
}
