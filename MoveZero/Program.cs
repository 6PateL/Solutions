using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.MoveZero
{
    public static class MoveZeroes
    {
        public static void MoveZero(int[] nums)
        {
            int lastZeroPos = 0;
            for(int i = 0;  i < nums.Length; i++) 
            {
                if (nums[i] != 0)
                {
                    (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                    lastZeroPos++;
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] b = { 2, 3, 0 };
            MoveZero(b);
        }
    }
}