using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int hight = 3 * n + 2;
            int leftDots = n;
            int middleType = width - (2*n + 2);
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', leftDots),
                        new string('*',middleType));
                    leftDots--;
                    middleType += 2;
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                       new string('.', leftDots),
                       new string('.', middleType));
                    leftDots--;
                    middleType += 2;
                }
            }
            Console.WriteLine(new string('*', width));

            leftDots = 1;
            middleType = width - 4;
            for (int i = 1; i <= 2*n+1; i++)
            {
                if (i == 2*n +1)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                    new string('.', leftDots),
                    new string('*', middleType));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                   new string('.', leftDots),
                   new string('.', middleType));
                    leftDots++;
                    middleType -= 2;
                }
               
            }
        }
    }
}
