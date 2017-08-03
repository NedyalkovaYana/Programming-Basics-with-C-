using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaxAreaSumMatrix
{
    class MaxAreaSumMatrix
    {
        static int[,] GetMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Enter Matrix[{0}, {1}]: ", row, col);
                    int.TryParse(Console.ReadLine(), out matrix[row, col]);
                }
            }
            return matrix;
        }

        static void GetMaxSumMatrix(int[,] matrix, int rows, int cols)
        {
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j <= col + 2; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                       
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
                
            }
            PrintMatrix(matrix, startRow, startCol);
        }

        static void PrintMatrix(int[,] matrix, int row, int col)
        {
            Console.WriteLine("\n The 3x3 matrix with the maximal sum is:");
            for (int i = row; i <= row + 2; i++)
            {
                for (int j = col; j <= col + 2; j++)
                {
                    Console.WriteLine("{0, 4}", matrix[i, j]);

                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(n, m);
            GetMaxSumMatrix(matrix, n, m);

        }
    }
}
