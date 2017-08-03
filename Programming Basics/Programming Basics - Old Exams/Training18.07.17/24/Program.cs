using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int leftRightStars = 1;
            int middleDash = width - 2 * leftRightStars - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                new string('*', leftRightStars),
                new string('-', middleDash));
                leftRightStars++;
                middleDash -= 2;
            }
            leftRightStars = n / 2;
            int middleStars = n;
            int ochi = n/3;
            for (int i = 0; i < ochi; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                    new string('*', leftRightStars),
                    new string('*', middleStars));
                leftRightStars++;
                middleStars -= 2;
            }
            int leftRightDash = 1;
            middleStars = width - 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', leftRightDash),
                    new string('*', middleStars));
                leftRightDash++;
                middleStars -= 2;
            }

        }
    }
}
