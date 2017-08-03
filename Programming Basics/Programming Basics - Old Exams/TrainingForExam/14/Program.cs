using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wight = (2 * n) - 1;
            int hight = (2 * n) - 1;
            int dots = n / 2;
            int middleDots = n - 2;
            int finalDots = 1;
            int finalMiddleDots = wight - 4;


            for (int i = 1; i <=hight; i++)
            {
                if (i ==1)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.',dots),
                        new string('#', n));
                }
                else if (i == n)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('#', (n/2) + 1),
                        new string('.', middleDots));
                }
                else if (i > n)
                {
                    if (finalMiddleDots <= 0)
                    {
                        Console.WriteLine("{0}#{0}",
                            new string('.', (wight - 1)/2));
                    }
                    else
                    {
                        Console.WriteLine("{0}#{1}#{0}",
                            new string('.', finalDots),
                            new string('.', finalMiddleDots));
                        finalDots++;
                        finalMiddleDots -= 2;
                    }

                }
                else
                {
                    Console.WriteLine("{0}#{1}#{0}",
                        new string('.', dots),
                        new string('.', middleDots));
                }
            }
        }
    }
}
