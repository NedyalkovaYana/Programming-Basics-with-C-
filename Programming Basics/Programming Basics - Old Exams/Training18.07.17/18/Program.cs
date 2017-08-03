using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int leftRightDots = (width - 2)/2;
            int blanckSpace = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
               new string('.', leftRightDots),
               new string(' ', blanckSpace));
                leftRightDots--;
                blanckSpace += 2;
            }
            leftRightDots++;
            Console.WriteLine("{0}{1}{0}",
                new string('.', leftRightDots),
                new string('*', blanckSpace));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('.', leftRightDots),
                    new string('\\', blanckSpace - 2));
            }
            blanckSpace -= 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', leftRightDots),
                    new string('*', blanckSpace));
                leftRightDots--;
                blanckSpace += 2;
            }
           
        }
    }
}
