using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace Solutions.ValidPalindrome
{
    public static class ValidPalindrome
    {
        public static bool IsValidPalindrome(string s)
        {
            //change operations
            List<char> list = new List<char>();
            s = s.ToLower(); 

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    list.Add(c); 
                }
            }

            //check palindrome
            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - 1 - i])
                {
                    return false;
                }
            }

            if (s.Contains(" "))
            {
                return true; 
            }

            return true;
        }
        public static void Main(string[] args)
        {
            string s1 = "a";
            string s2 = "amanaplanacanalpanama";
            string s3 = "race a car";
            string s4 = "A man, a plan, a canal: Panama"; 

            var result = s2.Count();
            Console.WriteLine(result);

            if (IsValidPalindrome(s4))
            {
                Console.WriteLine("palindrome"); 
            }
            if (!IsValidPalindrome(s4))
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}