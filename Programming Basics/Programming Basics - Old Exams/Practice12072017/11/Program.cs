using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int widht = (2 * n) - 1;
            int hight = (n / 2) + 4;
            int emptySpace = n - 2;
            int leftRightDots = 1;
            int middleDots = 1;

            Console.WriteLine("@{0}@{0}@", 
                new string(' ', emptySpace));
            emptySpace--;
            Console.WriteLine("**{0}*{0}**",
                new string(' ', emptySpace));
            emptySpace -= 2;

            for (int i = 1; i <= n/2; i++)
            {
                if (i == n/2)
                {
                    Console.WriteLine("*{0}{1}{2}{1}{0}*",
                        new string('.', leftRightDots),
                        new string('*', (middleDots - 1) / 2),
                        new string('.', 1));
                        
                }
                else if (emptySpace <=0)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                        new string('.', leftRightDots),                        
                        new string('.', middleDots));
                    leftRightDots++;
                    
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                        new string('.', leftRightDots),
                        new string(' ', emptySpace),
                        new string('.', middleDots));
                    leftRightDots++;
                    emptySpace -= 2;
                    middleDots += 2;
                }
            }
            Console.WriteLine(new string('*', widht));
            Console.WriteLine(new string('*', widht));
        }
    }
}
