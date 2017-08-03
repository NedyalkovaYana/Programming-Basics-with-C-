using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int addDots = 0;
            int removeDots = 0;

            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', 3*n),
                new string('.', n));
            for (int i = 1; i <n ; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', n-i),
                    new string('.', 3*n + addDots),
                    new string('.', n-i));
                addDots += 2;
            }
            Console.WriteLine("{0}",new string('*', 5*n));

            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.',i),
                    new string('.', (5*n - 2*i)-2));
                removeDots += 2;
            }
            Console.WriteLine("{0}{1}{0}",
                new string('.', 2 * n + 1),
                new string('*', 5*n-(4*n+2)));
                
        }
    }
}
