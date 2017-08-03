using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int midd = 0;
            
            for (int i = 0; i < n; i++)
            {
                int LeftRightDots = (3 * n - midd - 2) / 2;

                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.',LeftRightDots ),
                    new string(' ', midd));
               
                midd +=2;
            }
            Console.WriteLine("{0}{1}{0}",
                new string('.', (3*n - 2*n)/2),
                new string('*', 2*n));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('.', (3 * n - 2 * n) / 2),
                    new string('\\', 3*n-(3 * n - 2*n) - 2));
            }
            for (int i = n/2; i >0; i--)
            {
                midd = 3 * n - 2*i - 2 ;
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', i),
                    new string('*', midd));
               
            }

        }
    }
}
