using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int a = 1; a <=30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n)
                        {
                            if (a < b && b < c)
                            {
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                                count++;
                            }
                        }
                        if (a * b * c == n)
                        {
                            if (a > b && b > c)
                            {
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
