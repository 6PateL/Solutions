using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks; 

namespace Solutions.RomanToInt
{
    public static class RomanToInt
    {
        public static int romanToInt(string s)
        {
            Dictionary<char, int> numerals = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = 0; 

            for(int i = 0; i < s.Length; i++) 
            {
                if(i + 1 < s.Length && numerals[s[i]] < numerals[s[i + 1]])
                {
                    result = result - numerals[s[i]];
                }
                else
                {
                    result = result + numerals[s[i]]; 
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            string s1 = "III";
            string s2 = "LVIII";
            string s3 = "MCMXCIV";
            string s4 = "findMe"; 

            var result = romanToInt(s1);
            Console.WriteLine(result);

            //for (int i = 0; i < s4.Length; i++)
            //{
            //    if (i + 3 < s4.Length - 3)
            //    {
            //        Console.WriteLine(s4[i]);
            //    }
            //}
        }
    }
}