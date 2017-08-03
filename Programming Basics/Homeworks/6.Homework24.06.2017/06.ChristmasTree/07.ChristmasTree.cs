using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ChristmasTree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                Console.Write("{0}{1} | {1}{0}",
                    new string(' ', n-i),
                    new string('*', i));
                Console.WriteLine();
            }

        }
    }
}
