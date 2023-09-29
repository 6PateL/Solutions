using System;
using System.Collections.Generic;
using System.Linq;


namespace Solutions.FindContainsDuplicate
{
    public static class FindContainsDuplicate
    {
        public static bool findContainsDuplicate(int[] nums)
        {
            return nums.Distinct().Count() != nums.Count(); 
        }

        public static int findDuplicates(int[] nums)
        {
            var duplicates = nums.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key); //find duplicate
            var result = Convert.ToInt32(duplicates); 
            return result; 
        }

        public static void Main(string[] args)
        {
            int[] b = { 1, 2, 3, 3 };

            var result = b.Distinct().Count(); //duplicate contains here?
            var result1 = findDuplicates(b);

            Console.WriteLine(result);
            Console.WriteLine(result1); 

            //IEnumerable<int> duplicates = b.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key); //find duplicate
            //Console.WriteLine(duplicates);

            if (findContainsDuplicate(b))
            {
                Console.WriteLine("contains");
            }
            else
            {
                Console.WriteLine("not contains"); 
            }
        }
    }
}