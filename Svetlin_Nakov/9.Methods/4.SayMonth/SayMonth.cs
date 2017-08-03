using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SayMonth
{
    class SayMonth
    {   static void SayMonthnow(int month)
        {
            string[] monthNames = new string[]{"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December"};
            string monthName = monthNames[month - 1];
            Console.WriteLine(monthName);
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period = period + 12;
            }
            Console.Write("There are {0} months from ", period);
            SayMonthnow(startMonth);
            Console.Write(" to ");
            SayMonthnow(endMonth);
            Console.WriteLine(".");
        }
        static void Main()
        {
            Console.Write("First month (1 - 12): ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.Write("Second month (1-12): ");
            int secondmonth = int.Parse(Console.ReadLine());

            SayPeriod(firstMonth, secondmonth);
        }
    }
}
