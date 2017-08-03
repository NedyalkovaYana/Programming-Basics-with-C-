using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int height = n;
            int roofHeight = (n + 1) / 2;

            int leftRightDots = n / 2;
            int middleDots = 1;

            for (int i = 1; i < roofHeight; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}*{0}",
                        new string('.', leftRightDots));
                    leftRightDots--;
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', leftRightDots),
                        new string('.', middleDots));
                    leftRightDots--;
                    middleDots += 2;

                }
            }
            Console.WriteLine(new string('*', width));

            int wallDistance = n / 4;
            for (int i = 1; i < roofHeight; i++)
            {
                if (i == roofHeight - 1) 
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', wallDistance),
                        new string('*', n - 2 * wallDistance));
                }
                else
                {
                  
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', wallDistance),
                        new string('.', n - 2 * wallDistance - 2));
                }

            }

        }
    }
}
