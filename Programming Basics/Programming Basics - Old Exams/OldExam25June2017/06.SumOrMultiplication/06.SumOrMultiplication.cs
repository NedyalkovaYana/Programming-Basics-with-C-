using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOrMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <=n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (int c = Math.Max(a, b)+1; c <= n; c++)
                    {
                        if ( a < b  && b < c )
                        {
                            if ( a + b + c == n)
                            {
                                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, n);
                            }
                        }
                        else if (a > b && b > c)
                        {
                            if (a * b * c == n)
                            {
                                Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, n);
                               
                            }
                        }
                       
                    }
                }
            }
            Console.WriteLine("No!");
        }
    }
}
