using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlagotvoritelnaKompaniq
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumCakesForDay = cakes * 45;
            double sumGofretiForDay = gofreti * 5.80;
            double sumPancakesForDays = pancakes * 3.20;
            double sumByProductsForDays = (sumCakesForDay + sumGofretiForDay + sumPancakesForDays) * cookers;
            double sumForAllDays = sumByProductsForDays * days;

            double finalSum = sumForAllDays - (sumForAllDays * 0.125);

            Console.WriteLine("{0:f2}", finalSum);


        }
    }
}
