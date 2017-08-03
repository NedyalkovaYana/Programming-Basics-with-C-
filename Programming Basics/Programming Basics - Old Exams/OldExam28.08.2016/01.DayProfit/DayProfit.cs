using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayProfit
{
    class DayProfit
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double courseOfDollar = double.Parse(Console.ReadLine());

            double monthProfit = n * m;
            double yearProfit = (12 * monthProfit) + (2.5 * monthProfit);
            double vat = yearProfit * 25 / 100;
            double pureProfit = yearProfit - vat;
            double profitInLv = pureProfit * courseOfDollar;
            double dayProfit = profitInLv / 365;

            Console.WriteLine("{0:F2}", dayProfit);

        }
    }
}
