using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MagicNumbers
{
    class MagicNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    for (int a = 1; a <= 9; a++)
                    {
                        for (int b = 1; b <=9; b++)
                        {
                            for (int c = 1; c <=9; c++)
                            {
                                for (int d = 1; d <=9; d++)
                                {
                                    if (i*j*a*b*c*d == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ",
                                            i, j, a, b, c, d);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
