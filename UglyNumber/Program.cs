using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Solutions.UglyNumber
{
    public static class UglyNumber
    {
        public static bool IsUgly(int n)
        {
            if (n < 0) return false;
            if (n == 0) return true;

            while (n > 0)
            {
                if (n % 2 == 0) n = n / 2;
                else if (n % 3 == 0) n = n / 3;
                else if (n % 5 == 0) n = n / 5;
                else return false;
            }
            return true; 
        }

        public static void Main(string[] args)
        {
            int value = 14;
            var result = IsUgly(value);
            Console.WriteLine(result);
        }
    }
}