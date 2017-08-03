using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPathInLab
{
    class Program
    {
        static char[,] Lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' ', },
            {'*', '*', ' ', '*', ' ', '*', '*', },
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            {' ', '*', '*', '*', '*', '*', ' ', },
            {' ', ' ', ' ', ' ', ' ', ' ', 'e', },

        };
        static List<Tuple<int, int>> path = new List<Tuple<int, int>>();
        static bool InRange(int row, int col)
        {

        }
        static void Main()
        {
        }
    }
}
