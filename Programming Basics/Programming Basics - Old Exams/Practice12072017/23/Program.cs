using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 1;
            int hight = (2 * n) + 1;

            Console.WriteLine(new string('*', width));
            int leftRightDots = 1;
            int middle = width - 4;
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', leftRightDots),
                new string(' ', middle));
            leftRightDots++;
            middle -= 2;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', leftRightDots),
                    new string('@', middle));
                leftRightDots++;
                middle -= 2;
            }
            Console.WriteLine("{0}*{0}",
                new string('.', leftRightDots));
            leftRightDots--;
            middle = 0;
            for (int i = 1; i <= n-1; i++)
            {
                if (i == n - 1)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                         new string('.', leftRightDots),
                        new string('@', (2*middle) +1));
                }
                else
                {
                    Console.WriteLine("{0}*{1}@{1}*{0}",
                        new string('.', leftRightDots),
                        new string(' ', middle));
                    leftRightDots--;
                    middle++;
                }
            }
            Console.WriteLine(new string('*', width));
        }
    }
}
