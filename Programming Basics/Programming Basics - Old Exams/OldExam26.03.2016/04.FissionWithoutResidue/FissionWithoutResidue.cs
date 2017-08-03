using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FissionWithoutResidue
{
    class FissionWithoutResidue
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < numbers; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
               if (num % 3 == 0)
                {
                    p2++;
                }
               if (num % 4 == 0)
                {
                    p3++;
                }
               
            }
            
            Console.WriteLine("{0:f2}%", p1/ numbers * 100);
            Console.WriteLine("{0:f2}%", p2 / numbers * 100);
            Console.WriteLine("{0:f2}%", p3 / numbers * 100);
        }
    }
}
