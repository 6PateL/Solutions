using Solutions.Matrix;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks; 

namespace Solutions.PowerOfThree
{
    public static class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            if(n == 0) return false;

            while (n != 1)
            {
                if (n % 3 != 0)
                {
                    return false;
                }
                n = n / 3;
            }
            return true;
        }
        

        //public static int powerOfThree(int n) 
        //{
        //    if (n == 0)
        //    {
        //        Console.WriteLine("error");
        //    }

        //    while (n != 1) 
        //    {
        //        if( n % 3 != 0) 
        //        {
        //            Console.WriteLine("not power");
        //        }
        //        n = n / 3;  
        //    }
        //    return n; 
        //}

        public static void Main(string[] args) 
        {
            int n = 27;
            var result = IsPowerOfThree(n);
            //var result2 = powerOfThree(n); 
            Console.WriteLine(result);
        }
    }
}