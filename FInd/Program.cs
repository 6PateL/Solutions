using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Find
{
    public static class FindSingleObject
    {
        public static int FindSingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).First();
        }
        public static void Main(string[] args)
        {
            int[] b = { 2, 2, 2 };
            var result = FindSingleNumber(b);
            Console.WriteLine(result);
        }
    }
}