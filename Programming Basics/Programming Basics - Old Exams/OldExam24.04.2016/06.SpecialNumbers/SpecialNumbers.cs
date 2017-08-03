using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int a = 1; a <= 9; a++)
                    {
                        for (int b = 1; b <= 9; b++)
                        {
                            if (n % i == 0 && n % j== 0 && 
                                n % a == 0 && n % b== 0 )
                            {
                                Console.Write("{0}{1}{2}{3} ",
                                    i, j, a, b);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
