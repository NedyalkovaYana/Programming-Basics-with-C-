using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int hight = (2 * n) + 1;
            int leftRightDots = 1;
            int leftRightTriangle = (2 * n) - 1;
            int middleTriangle = 1;
            int triangle = (2 * n) - 1;            
            int leftRightDotsFinal = n + 1;

            for (int i = 0; i < hight; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}", 
                        new string('#', width));
                }
                else if (i == 1)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', leftRightDots),
                        new string('#', leftRightTriangle),
                        new string(' ', middleTriangle));
                    leftRightDots++;
                    leftRightTriangle -= 2;
                    middleTriangle += 2;
                }
               
                else if (i >= 2 && i <= n)
                {
                    if (i == (n / 2) + 1)
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                            new string('.', leftRightDots),
                            new string('#', leftRightTriangle),
                            new string(' ', (width - 2 * leftRightTriangle - 2 * leftRightDots - 3)/2));
                        leftRightDots++;
                        leftRightTriangle -= 2;
                        middleTriangle += 2;
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}",
                      new string('.', leftRightDots),
                      new string('#', leftRightTriangle),
                      new string(' ', middleTriangle));
                        leftRightDots++;
                        leftRightTriangle -= 2;
                        middleTriangle += 2;
                    }
  
                }

                else if (i >= n + 1)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', leftRightDotsFinal),
                        new string('#', triangle));
                    leftRightDotsFinal++;
                    triangle -= 2;
                }
            }
        }
    }
}
