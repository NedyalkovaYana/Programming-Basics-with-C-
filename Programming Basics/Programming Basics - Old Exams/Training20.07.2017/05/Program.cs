using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int leftDash = 3 * n;
            int middleDash = 0;
            int rightDash = width - (leftDash + middleDash + 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    new string('-', middleDash),
                    new string('-', rightDash));
                middleDash++;
                rightDash--;
            }
            leftDash++;
            middleDash--;
            rightDash++;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}*{2}",
                    new string('*', leftDash),
                    new string('-', middleDash),
                    new string('-', rightDash));
            }

            leftDash--;
            for (int i = 0; i < n/2 -1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    new string('-', middleDash),
                    new string('-', rightDash));
                leftDash--;
                middleDash += 2;
                rightDash--;
            }

            Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    new string('*', middleDash),
                    new string('-', rightDash));
        }
    }
}
