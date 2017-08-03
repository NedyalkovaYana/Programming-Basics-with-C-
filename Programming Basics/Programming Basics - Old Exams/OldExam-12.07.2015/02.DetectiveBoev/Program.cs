using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widthBottom = 2 * n;
            int widthTop = n + 1;
            int height = (3 * n) + 1;
            int throwt = (n / 2) + 1;
            int leftFreeSpace = n / 2;
            int restOfBottle = height - throwt - 2;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}",
                new string(' ', leftFreeSpace),
                new string('*', widthTop));
                }
                else if (i <= throwt)
                {
                    Console.WriteLine("{0}*{1}*",
                    new string(' ', leftFreeSpace),
                    new string(' ', n - 1));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*",
                   new string(' ', --leftFreeSpace),
                   new string(' ', widthTop));

                    widthTop += 2;
                }
            }
            int middleFreeSpace = (2 * n) - 2;
            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    Console.WriteLine("*{0}*",
                        new string('.', middleFreeSpace));
                }
                else
                {
                    Console.WriteLine("*{0}*",
                        new string('@', middleFreeSpace));
                }
            }
            Console.WriteLine(new string('*', widthBottom));
        }
    }
}
