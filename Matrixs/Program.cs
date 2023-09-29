using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Solutions.Matrix
{
    public static class Matrixs
    {
        public static double[][] MatrixCreate(int rows, int cols)
        {
            double[][] result = new double[rows][];
            for(int i = 0; i < rows; i++)
            {
                result[i] = new double[cols];
            }
            return result; 
        }

        public static string MatrixAsString(double[][] matrix)
        {
            string s = "";

            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    s += matrix[i][j].ToString("F3").PadLeft(8) + " ";
                    s += Environment.NewLine;
                }
            }
            return s; 
        } 

        public static double[][] MatrixProduct(double[][] A, double[][] B)
        {
            int aRows = A.Length; int aColumns = A[0].Length;
            int bRows = B.Length; int bColums = B[0].Length;

            if (aColumns != bRows)
            {
                throw new Exception("Non-conformable matrices in MatrixProduct"); 
            }

            double[][] result = MatrixCreate(aRows, bColums);
            for(int i = 0; i < aRows; ++i)
            {
                for(int j = 0; j < bColums; ++j)
                {
                    for(int k = 0; k < aColumns; ++k)
                    {
                        result[i][j] += A[i][k] * B[k][j]; 
                    }
                }
            }
            return result; 
        }

        public static double[][] CreateRandomMatrix(int rows, int cols, int minVals, int maxVals, int seed)
        {
            Random rnd = new Random(seed);

            double[][] result = MatrixCreate(rows,cols);
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    result[i][j] = (maxVals - minVals) * rnd.NextDouble() + minVals; 
                }
            }
            return result; 
        }

        public static void Main(string[] args)
        {
          double[][] matrix1 = MatrixCreate(4, 4);
          double[][] matrix2 = MatrixCreate(4,4);

          var matrixToString = MatrixAsString(matrix1);
          var matrixProduct = MatrixProduct(matrix1, matrix2);
          var randomMatrix = CreateRandomMatrix(3, 4, 0, 10, 1);

          Console.WriteLine(matrixToString);
          Console.WriteLine("\n");
          Console.WriteLine(matrixProduct);
          Console.WriteLine("\n");
          Console.WriteLine(randomMatrix);

            Math.Log2(Math.Log2(10)); 
        }
    }
}