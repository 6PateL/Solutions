using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.MoveZero
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var rs = new List<IList<int>> { new List<int> { 1 } };
            for (int i = 2; i <= numRows; i++)
            {
                var list = new List<int> { 1 };
                for (int j = 1; j < i - 1; j++)
                {
                    list.Add(rs[rs.Count - 1][j - 1] + rs[rs.Count - 1][j]);
                }
                list.Add(1);
                rs.Add(list);
            }
            return rs;
        }
        public static void Main(string[] args)
        {
            int _numRows = Convert.ToInt32(Console.ReadLine());
            var result = Generate(_numRows);
            Console.WriteLine(result);
        }
    }
}