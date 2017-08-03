using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int higth = (2 * n) + 1;

            Console.WriteLine(new string('#', width));

            int dots = 1;
            int dash = (2 * n) - 1;
            int blankSpace = 1;
            for (int i = 1; i <= n ; i++)
            {
                if (i == (n/2) + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                        new string('.', dots),
                        new string('#', dash),
                        new string(' ', (n/2)-1));
                    dots++;
                    dash -= 2;
                    blankSpace += 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', dots),
                        new string('#', dash),
                        new string(' ', blankSpace));
                    dots++;
                    dash -= 2;
                    blankSpace += 2;
                }
            }

            dash = (2 * n) - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', dash));
                dots++;
                dash -= 2;
            }

        }
    }
}
