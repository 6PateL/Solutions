using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; 

namespace Solutions.ReverseString
{
    public static class ReverseString
    {
        public static void reverseString(char[] s)
        {
           Array.Reverse(s);
           Console.WriteLine(s);
        }

        public static void Main(string[] args)
        {
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            reverseString(chars); 
        }
    }
}