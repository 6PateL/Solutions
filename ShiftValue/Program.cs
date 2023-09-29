using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Solutions.ShiftValue
{
    public static class ShiftValue
    {
        public static int AddZeroBinary(int value, int zeroCount)
        {
            var result = value << zeroCount;
            return result; 
        }

        public static int RemoveBinary(int value, int removeCount) 
        {
            var result = value >> removeCount;
            return result; 
        }
        public static void Main(string[] args)
        {
            var value1 = 7 << 5; //11100000 shifted by 5 zeroes(binary format) 
            var value2 = 7; //111 
            var value3 = 7 >> 2; //0 7 >> 5 //1 7 >> 2
            // (<< add 0) (>> delete values) 
            var value4 = 10 >> 1;
            Console.WriteLine($"Shifted byte: {Convert.ToString(value1, toBase: 2)}");
            Console.WriteLine($"Shifted byte: {Convert.ToString(value2, toBase: 2)}");
            Console.WriteLine($"Shifted byte: {Convert.ToString(value3, toBase: 2)}");
            Console.WriteLine($"Shifted byte: {Convert.ToString(value4, toBase: 2)}");
        }
    }
}