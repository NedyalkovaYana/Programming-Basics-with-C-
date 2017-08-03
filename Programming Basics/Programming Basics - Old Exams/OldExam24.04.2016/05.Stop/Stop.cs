using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Stop
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', n+1),
                new string('_',2*n+1));

            int a = 2 * n - 1;
            for (int i = n; i >=1; i--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', i),
                    new string('_', a));
                a += 2;

            }
            a = 2 * n - 3;
            Console.WriteLine("//{0}STOP!{0}\\\\",
                new string('_', a));
            a = 4 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", 
                    new string('.', i), 
                    new string('_', a));
                a -= 2;
            }
        }
    }
}
