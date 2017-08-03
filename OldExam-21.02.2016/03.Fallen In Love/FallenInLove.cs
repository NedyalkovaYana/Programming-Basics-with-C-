using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fallen_In_Love
{
    class FallenInLove
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int middle = 0;
            int right = 0;
            int dots = 2 * n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                    new string('~', left),
                    new string('.', dots),
                    new string('.', middle));
                left++;
                dots -= 2;
                middle += 2;
            }
            left = 1;
            int listo = n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                    new string('.', left),
                    new string('~', listo),
                    new string('.', middle));
                left += 2;
                listo--;
                middle -= 2;
            }

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}####{0}",
                        new string('.', left));
                    left++;
                }
                else
                {
                    Console.WriteLine("{0}##{0}",
                        new string('.', left));
                }
            }

        }
    }
}
