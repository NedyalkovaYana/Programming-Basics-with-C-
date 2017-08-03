using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dash = 0;

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('*', i),
                    new string('-', (2*n + 3)-2 -2*i));
               
            }
            for (int i = 1; i <=n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                    new string('*',(((2 * n + 3)-n - 4)/2)+ dash),
                    new string('*', (2 * n + 3) - 2* ((((2 * n + 3) - n - 4) / 2) + dash) - 4));
                    dash++;
            }
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', i),
                    new string('*', (2 * n + 3) - 2 - 2 * i));
            }
        }
    }
}
