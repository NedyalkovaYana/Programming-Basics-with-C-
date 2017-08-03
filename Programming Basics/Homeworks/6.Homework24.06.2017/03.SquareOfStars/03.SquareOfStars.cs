using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareOfStars
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *", j);
                }
                Console.WriteLine();
            }

        }
    }
}
