using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRightDots = n + 1;
            int middlePart = 2 * n + 1; 
            for (int  i = 1;  i <= n + 1;  i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', leftRightDots),
                        new string('_', middlePart));
                    leftRightDots --;
                    middlePart = 2*n - 1;
                }
                else
                {
                    Console.WriteLine("{0}//{1}\\\\{0}",
                        new string('.', leftRightDots),
                        new string('_', middlePart));
                    leftRightDots--;
                    middlePart += 2;
                }
                
            }
            middlePart = (middlePart - 5) /2;
            Console.WriteLine("//{0}STOP!{0}\\\\",
                new string('_', middlePart));
            middlePart = 4 * n - 1;
               Console.WriteLine("\\\\{0}//",
               new string('_', middlePart));
            middlePart -= 2;
            leftRightDots = 1;
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', leftRightDots),
                    new string('_', middlePart));
                leftRightDots++;
                middlePart -= 2;

            }
        }
    }
}
