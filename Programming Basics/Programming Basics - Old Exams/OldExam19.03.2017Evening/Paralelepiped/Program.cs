using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightDots = (3 * n + 1) - n - 2 + 2;
            int leftDots = 0;

            for (int i = 1; i <= (n * 2) + 2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("+{0}+{1}",
                        new string('~', n - 2),
                        new string('.', rightDots));
                    
                }
                else if (i == 2)
                {
                    rightDots--;
                    Console.WriteLine("|\\{0}\\{1}",
                        new string('~', n - 2),
                        new string('.', rightDots));
                    
                }
                else
                {
                    leftDots++;
                    rightDots--;
                    Console.WriteLine("|{0}\\{1}\\{2}",
                        new string('.', leftDots),
                        new string('~', n - 2),
                        new string('.', rightDots));
                    

                }
            }
            int middleDots = 2 * n;
            int leftDot = 0;
            int h = 2*n + 2;
            for (int i = 1; i <= h; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("\\{0}|{1}|",
                        new string('.',middleDots),
                        new string('~', n - 2));
                }
                else if (i >= 2 && i <= 2*n+1)
                {
                    middleDots--;
                    leftDot++;
                    Console.WriteLine("{0}\\{1}|{2}|",
                        new string('.', leftDot),
                        new string('.', middleDots),
                        new string('~', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}+{1}+",
                        new string('.', 2*n + 1),
                        new string('~', n - 2));
                }
            }
        }
    }
}


                        
                        
                     
