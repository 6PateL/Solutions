using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Solutions.FindInArray
{
    public static class Extensions
    {
        public static bool find<T>(this T[] array, T target)
        {
            return array.Contains(target);
        }

        public static int findAndReturn<T>(this T[] array, T target)
        {
            if (array.Contains(target))
            {
                var result = Convert.ToInt32(target);
                return result; 
            }
            else
            {
                throw new Exception("target was not found"); 
            }
        }

        public static int findIndex<T>(this T[] array, T items)
        {
            return Array.IndexOf(array, items);  
        }
    }

    public static class FindInArray 
    {
        public static int findByIndex(List<int> list, int index)
        {
            List<int> c = new List<int>();
            c.AddRange(list);
            var result = c.IndexOf(index);
            
            return result;  
        }
        public static bool findContainsDuplicate(List<int> nums)
        {
            return nums.Distinct().Count() != nums.Count();
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 3;

            //target exists?
            bool IsExist = array.find(target);
            if (IsExist)
            {
                Console.WriteLine("Exist");
            }
            else
            {
                Console.WriteLine("not exist");
            }

            //if target exists return target value
            int value = array.findAndReturn(target);
            Console.WriteLine(target + value);

            //find index with value
            int index = array.findIndex(target);
            if (index != -1)
            {
                Console.WriteLine((String.Format("Element {0} is found at index {1}", target, index)));
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }

            //find value with index(works with list only and only with int values)
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            List<int> removeDuplicates = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (findContainsDuplicate(list))
                {
                    continue;
                }
                removeDuplicates.Add(i);
            }
            var result = findByIndex(removeDuplicates, 6);
            Console.WriteLine(result);
        }
    }
}