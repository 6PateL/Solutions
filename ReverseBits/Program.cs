using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Solutions.ReverseBits
{
    public static class ReverseBits
    {
        public static uint reverseBits(uint n)
        {
            var reverse = n.ToString().ToArray();
            Array.Reverse(reverse);
            var reversedArray = Convert.ToString(reverse);

            var result = BinaryToDecimal(reversedArray);

            return result;
        }
        static uint BinaryToDecimal(string binaryNumber)
        {
            var exp = 1u;
            var result = 0u;
            for (var i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                {
                    result += exp;
                }
                exp *= 2;
            }

            return result;
        }
        public static void Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            var result = reverseBits(n);
            Console.WriteLine(result);
        }

        //Alternative way: 
        //public uint reverseBits(uint n)
        //{
        //    uint reversed = 0;
        //    for (int i = 0; i < 32; i++)
        //    {
        //        reversed = reversed << 1;
        //        if (n % 2 == 1)
        //            reversed++;
        //        n = n >> 1;
        //    }
        //    return reversed;
        //}
    }
}