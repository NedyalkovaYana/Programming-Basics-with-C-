using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int wight = (4 * n) + 1;
            int hight = (2 * n) + 5;
            int leftRightDots = (wight - 3)/2 ;
            int middleDash = 1;

            for (int i = 0; i < (2*n) + 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}/|\\{0}",
                        new string('.', leftRightDots));
                }
                else if (i == 1)
                {
                    Console.WriteLine("{0}\\|/{0}",
                        new string('.', leftRightDots));
                }
                else if (i == 2)
                {
                    Console.WriteLine("{0}***{0}",
                        new string('.', leftRightDots));
                    leftRightDots--;
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}",
                        new string('.', leftRightDots),
                        new string('-', middleDash));
                    leftRightDots--;
                    middleDash++;
                }
            }
            Console.WriteLine("{0}",
                new string('*', wight));

            Console.Write("*");
            Console.Write(".");
            for (int i = 0; i < (4 * n - 1) / 2; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");


            Console.WriteLine("{0}",
                new string('*', wight));
        }
    }
}
