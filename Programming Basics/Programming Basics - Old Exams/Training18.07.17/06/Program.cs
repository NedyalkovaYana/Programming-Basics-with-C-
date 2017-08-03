using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hight = 4 * n - 2;
            int widght = 12 * n - 5;
            int dash = 1;
            int leftRightDots = (widght - 1) / 2;

            for (int i = 1; i <= hight/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRightDots),
                    new string('#', dash));
                dash += 6;
                leftRightDots -= 3;
            }
            Console.WriteLine(new string('#', widght));
            int middleFor = hight - ((2 * n - 1) + n)-1;
            int leftDots = 2;
            int rightDots = 3;
            dash -= 6;
            for (int i = 1; i <= middleFor; i++)
            {
                Console.WriteLine("|{0}{1}{2}",
                    new string('.', leftDots),
                    new string('#', dash),
                    new string('.', rightDots));
                leftDots += 3;
                rightDots += 3;
                dash -= 6;
            }

            int rightDotsNew = widght - dash;
            int finalDots = rightDotsNew / 2;

            for (int i = 1; i <= n; i++)
            {
               
                if (i == n)
                {
                    Console.WriteLine("@{0}{1}{2}",
                   new string('.', leftDots),
                   new string('#', dash),
                   new string('.', finalDots));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}",
                   new string('.', leftDots),
                   new string('#', dash),
                   new string('.', finalDots));
                }
               
            }
        }
    }
}
