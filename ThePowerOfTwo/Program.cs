using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks; 

namespace Solutions.ThePowerOfTwo
{
    public static class ThePowerOfTwo
    {
        public static bool IsPowerOfTwo(int value) 
        {
            if(value == 0) return false;

            double mx = Math.Log2(value);
            if (Math.Pow(2, Math.Round(mx)) == value)
            {
                return true;
            }
            return false; 
        }
        public static void Main(string[] args)
        {
            int value = 16;
            var result = IsPowerOfTwo(value);
            Console.WriteLine(result);

            //double math = Math.Log2(value);
            //var result = Math.Round(math);
            //Console.WriteLine(result); 
        }
    }
}