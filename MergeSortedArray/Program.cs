using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.MergeSortedArray
{
    public static class MergedArray
    {
        public static void MergeSortedArray(int[] num1, int m, int[] num2, int n)
        {
            num1 = new int[m];
            num2 = new int[n];
           
            var result = num1.Concat(num2); 

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == 0 || num2[i] == 0)
                    {
                        continue;                    }
                    {
                        result = num1.Concat(num2);
                    }
                }
            }

            Console.WriteLine(result);

            //Right answer: 
            //public void Merge(int[] nums1, int m, int[] nums2, int n)
            //{
            //    Array.Copy(nums2, 0, nums1, m, n);
            //    Array.Sort(nums1);
            //}
        }
        public static void Main(string[] args)
        {
            int[] num1 = { 1, 1, 2, 3 };
            int[] num2 = { 1, 1, 2, 3 };
            int m = 4;
            int n = 4;

            MergeSortedArray(num1, m, num2, n); 
        } 
    }
}