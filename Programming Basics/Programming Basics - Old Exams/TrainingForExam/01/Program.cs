using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int daysInMont = 31;
            if (month == 2)
            {
                daysInMont = 28;
            }
            if ((month == 4)|| (month == 6)||
                (month == 9)||(month == 11))
            {
                daysInMont = 30;
            }

            day += 5;

            if (day > daysInMont)
            {
                day -= daysInMont;
                month++;
                if (month > 12)
                {
                    month = 1;
                }
            }
            Console.WriteLine($"{day}.{month:d2}");
        }
    }
}
