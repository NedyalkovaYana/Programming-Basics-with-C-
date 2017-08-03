using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col >= 1)
                    {
                                               Console.Write(num);
                        Console.Write(" ");
                        num++;
                        if (num > n) break;
                    }
                }
                Console.WriteLine();
                if (num > n) break;

            }
        }
    }
}
