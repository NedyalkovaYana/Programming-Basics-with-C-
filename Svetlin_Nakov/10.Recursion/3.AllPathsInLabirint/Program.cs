//#define DEBUG_MODE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AllPathsInLabirint
{
    class Program
    {
        static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' ',},
            {'*', '*', ' ', '*', ' ', '*', ' ',},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ',},
            {' ', '*', '*', '*', '*', '*', ' ',},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e',},
        };
        static List<Tuple<int, int>> path = new List<Tuple<int, int>>();
        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }
        static void FindPathToExit(int row, int col)
        {
#if DEBUG_MODE
            PrintPath(row, col);
#endif

            if (!InRange(row, col))
            {
                //We are out of labirina and can not find a path
                return;
            }
            //Check if we have found a exit
         
            if (lab[row, col] == 'e')
            {
                PrintPath(row, col);
            }
            if (lab[row, col] != ' ')
            {
                //The current cel is not free, cant found a path
                return;
            }
            //Temporary mark the current cell as visited
            lab[row, col] = 's';
            path.Add(new Tuple<int, int>(row, col));
            //Invoke recurtion the explore all possible direction
            FindPathToExit(row, col - 1); // left
            FindPathToExit(row - 1, col); // up
            FindPathToExit(row, col + 1); // right
            FindPathToExit(row + 1, col); //down
            //Mark back current cell as free
            lab[row, col] = ' ';
            path.RemoveAt(path.Count - 1);
        }
        private static void PrintPath(int finalRow, int finalCol)
        {
            Console.Write("Find the exit: ");
            foreach (var cell in path)
            {
                Console.Write("({0},{1}) -> ", cell.Item1, cell.Item2);
            }
            Console.WriteLine("({0},{1})", finalRow, finalCol);
        }


        static void Main(string[] args)
        {
            //Uncomment the code below to create larger labirint. 
            //Test with size 10 and size 100;

            //int size = 10;
            //lab = new char[size, size];
            //for (int row = 0; row < size; row++)
            //{
            //    for (int col = 0; col < size; col++)
            //    {
            //        lab[row, col] = ' ';
            //    }
            //}
            //lab[size - 1, size - 1] = 'e';
            FindPathToExit(0, 0);
        }
    }
}
