using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hight = n;
            int leftRightDots = n/2;
            int endSymbol = n / 2 + 1;
            int middleDots = n;
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', leftRightDots),
                new string('&', endSymbol),
                new string('.', middleDots));
            leftRightDots--;
            int stars = endSymbol - 1;
            for (int i = 1; i < n/2; i++)
            {
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                        new string('.',leftRightDots),
                        new string('*', stars),
                        new string('.', middleDots));
                    leftRightDots--;
                    stars++;
            }
            Console.WriteLine("&{0}&{1}&{0}&",
                       new string('*', stars),
                       new string('=', middleDots));
            stars--;
            leftRightDots = 1;
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                       new string('.', leftRightDots),
                       new string('*', stars),
                       new string('.', middleDots));
                leftRightDots++;
                stars--;
            }

            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', leftRightDots),
                new string('&', endSymbol),
                new string('.', middleDots));
        }
    }
}
