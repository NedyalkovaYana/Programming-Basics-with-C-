using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfArrays
{
    class ReadPrintMatrix
    {
        static void Main()
        {
            //Read the matrix from console Вариант 1
            //string str = Console.ReadLine();
            //string[] tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Ако има интервали маха празното
            //int rows = int.Parse(tokens[0]);
            //int cols = int.Parse(tokens[1]);

            //Read the Matrix dimentios Препоръчителния вариант
            //Console.Write("Numbers of rows = ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Numbers of columns = ");
            //int cols = int.Parse(Console.ReadLine());

            ////Alocate the matrix
            //int[,] matrix = new int[rows, cols];

            ////Enter the matrix element
            //for (int row = 0; row < rows; row++)
            //{
            //    //str = Console.ReadLine();
            //    //tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write("Matrix [{0}, {1}]= ", row, col);
            //        int element = int.Parse(Console.ReadLine());//int element = int.Parse(tokens[col]);
            //        matrix[row, col] = element;
            //    }
            //}

            int[,] matrix =
            {
                {1, 2, 3, 4, 5},
                {8, 9, 0, 5, 3}
            };
            

            //Print the matrix on the console
            Console.WriteLine();
            Console.WriteLine("The matrix is as follows:");
            for (int row = 0; row < rows; row++)// Ще работи дадената матрица ако вместо rows напишем matrix.GetLength(0), аналогично и за cols ;)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,2}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
