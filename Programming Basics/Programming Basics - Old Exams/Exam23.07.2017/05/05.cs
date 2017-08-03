using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int leftRightDots = n;
            int middle = 3 * n;

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRightDots),
                    new string('#', middle));
                leftRightDots++;
                middle -= 2;

            }
            middle -= 2;
            for (int i = 0; i <n/2+1;  i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.',leftRightDots),
                    new string('.', middle));
                leftRightDots++;
                middle -= 2;
            }
            leftRightDots--;
            middle =n;
            Console.WriteLine("{0}{1}{0}",
                new string('.',leftRightDots ),
                new string('#', middle));
            middle += 4;
            leftRightDots -= 2;
            for (int i = 0; i <n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRightDots),
                    new string('#', middle));
            }
            leftRightDots = (width - 10)/2;
            Console.WriteLine("{0}D^A^N^C^E^{0}",
                new string('.', leftRightDots));

            leftRightDots = 2 * n - 2;
            for (int i = 0; i <n/2+1; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRightDots),
                    new string('#', middle));
            }
        }
    }
}
