using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; 

namespace Solutins.AddStrings
{
    public static class AddStrings
    {
        public static string addStrings(string num1, string num2)
        {
            var resultNum1 = Convert.ToInt64(num1);
            var resultNum2 = Convert.ToInt64(num2);

            var result = resultNum1 + resultNum2;

            return result.ToString();

            //(BigInteger.Parse(num1) + BigInteger.Parse(num2)).ToString();
        }

        public static void Main(string[] args)
        {
            string num1 = "11";
            string num2 = "123";

            var result = addStrings(num1, num2);
            Console.WriteLine(result);
        }
    }
}