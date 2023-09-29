using System;
using System.Collections;
using System.Threading.Tasks;
using System.Linq; 

namespace Solutions.FindTheDifference
{
    public static class FindTheDifference
    {
        public static char findTheDifference(string s, string t)
        {
            int result = 0;

            foreach (char c in t) result += c;
            foreach (char c in s) result -= c;

            return (char)result; 
        }
        public static void Main(string[] args)
        {
            string word = "abcd";
            string word2 = "abcde"; 

            var result = findTheDifference(word, word2);
            Console.WriteLine(result);
        }
    }
}