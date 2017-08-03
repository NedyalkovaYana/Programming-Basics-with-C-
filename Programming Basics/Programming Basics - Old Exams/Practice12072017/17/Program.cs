using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (3 * n) + 1;
            int hight = (4 * n) + 4;
            int rightDots = (n * 2) +1;
            int leftDots = 0;
            Console.WriteLine("+{0}+{1}",
                new string('~', n-2),
                new string('.',rightDots));
            rightDots--;
            for (int i = 1; i <= (2 * n) + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', leftDots),
                    new string('~', n - 2),
                    new string('.', rightDots));
                leftDots++;
                rightDots--;
            }
            leftDots = 0;
            rightDots = 2 * n; 
            for (int i = 1; i <= (2 * n) + 1; i++)
            {
                if (rightDots <=0)
                {
                    Console.WriteLine("{0}\\|{1}|",
                    new string('.', leftDots),                
                    new string('~', n - 2));
                    leftDots++;                  
                }
                else
                {
                    Console.WriteLine("{0}\\{1}|{2}|",
                   new string('.', leftDots),
                   new string('.', rightDots),
                   new string('~', n - 2));
                    leftDots++;
                    rightDots--;
                }
               
            }
            Console.WriteLine("{0}+{1}+",
                new string('.', leftDots),
                new string('~', n-2));
        }
    }
}
