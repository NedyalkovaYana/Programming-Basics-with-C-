using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        private static string GenerateFrom(string input, int times)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                builder.Append(input);
            }

            return builder.ToString();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hight = 2 * n + 5;
            int wight = 4 * n + 1;
            int leftRightDots = 2 * n - 1;
            Console.WriteLine("{0}/|\\{0}",
                  new string('.', leftRightDots));
            Console.WriteLine("{0}\\|/{0}",
                  new string('.', leftRightDots));
            int middleDash = 0;
            for (int i = 1; i <= 2*n; i++)
            {
                if (i == 2*n)
                {
                    Console.WriteLine("*{0}*{0}*",
                    new string('-', middleDash));                  
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}",
                     new string('.', leftRightDots),
                     new string('-', middleDash));
                    leftRightDots--;
                    middleDash++;
                }
            }
            Console.WriteLine(new string('*', wight));
            Console.Write("*");
            Console.Write(GenerateFrom(".*", 2*n ));
            Console.WriteLine();
            Console.WriteLine(new string('*', wight));
        }
    }
}
