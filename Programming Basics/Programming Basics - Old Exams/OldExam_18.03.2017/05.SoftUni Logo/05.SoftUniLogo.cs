using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUni_Logo
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dash = 1;
            

            for (int i = 1; i <= n*2; i++)
            {
                int leftRight = (12 * n - 5 - dash) / 2;

                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRight),
                    new string('#', dash));
                dash += 6;
            }
            int allH = (4 * n) - 2;
            int upperPiece = 2 * n;
            int downPiece = n;
            int middlePiece = allH - upperPiece - n;
            int leftDots = 2;
            int rightDots = 3;
            int midd = (12 * n - 5) - 6;
            for (int i = 0; i < middlePiece; i++)
            {
                Console.WriteLine("|{0}{1}{2}",
                    new string('.', leftDots),
                    new string('#', midd ),
                    new string('.', rightDots ));
                rightDots += 3;
                leftDots += 3;
                midd = (12 * n - 5) - rightDots - leftDots - 1;
            }
            int dashes = 6 * n + 1;
            int dotss = (12 * n - 5) - dashes;
            int leftDotss = (dotss / 2) - 1;
            int rightDotss = dotss / 2;
            for (int i = 1; i <= n; i++)
            {
                

                if (i == n)
                {
                    Console.WriteLine("@{0}{1}{2}",
                        new string('.', leftDotss),
                        new string('#', dashes),
                        new string('.', rightDotss));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}",
                        new string('.', leftDotss),
                        new string('#', dashes),
                        new string('.', rightDotss));
                }
                

            }
        }
    }
}
