using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = ReplaceZeroAndOne(input);
            Console.WriteLine(result);
        }
        public static string ReplaceZeroAndOne(string input)
        {
            List<char> zeroes = new List<char>();
            List<char> ones = new List<char>(); 

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '0')
                {
                    zeroes.Add(input[i]);
                }
                else if (input[i] == '1')
                {
                    ones.Add(input[i]); 
                }
                else
                {
                    throw new Exception("некоректный ввод данных");
                }
            }

            string zeroesSorted = new string(zeroes.ToArray());
            string onesSorted = new string(ones.ToArray());

            return zeroesSorted + onesSorted; 
        }
    }
}
