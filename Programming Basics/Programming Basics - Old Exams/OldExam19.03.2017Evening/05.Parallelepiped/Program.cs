using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int rightDots = (3 * n + 1) - n - 2 + 2;
            int leftDots = 1;

            for (int i = 1; i <= (n * 2) + 2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("+{0}+{1}",
                        new string('~', n - 2),
                        new string('.', rightDots));
                    rightDots--;
                }
                else if (i == 2)
                {
                    Console.WriteLine("|\\{0}\\{0}",
                        new string('~', n - 2),
                        new string('.', rightDots));
                    rightDots--;
                }
                else
                {
                    Console.WriteLine("|{0}\\{1}\\{2}",
                        new string('.', leftDots),
                        new string('~', n - 2),
                        new string('.', rightDots)););
                        leftDots++;













