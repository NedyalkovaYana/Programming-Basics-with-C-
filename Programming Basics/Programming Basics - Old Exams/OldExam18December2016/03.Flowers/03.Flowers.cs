using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main()
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double chrysanthemumsPrice = 0.0;
            double rosePrice = 0.0;
            double tulipsPrice = 0.0;

            if (seasson == "spring" || seasson =="summer" )
            {
                chrysanthemumsPrice = chrysanthemums * 2.00;
                rosePrice = rose * 4.10;
                tulipsPrice = tulips * 2.50;
            }
            else if (seasson == "autumn" || seasson == "winter")
            {
                chrysanthemumsPrice = chrysanthemums * 3.75;
                rosePrice = rose * 4.50;
                tulipsPrice = tulips * 4.15;
            }
            double sumFlowers = chrysanthemumsPrice + rosePrice + tulipsPrice;
            if (holiday == "y")
            {
                sumFlowers = sumFlowers + (sumFlowers * 15) / 100;
            }
            if (seasson =="spring" && tulips >7)
            {
                sumFlowers = sumFlowers - (sumFlowers * 5) / 100;
            }
            if (seasson == "winter" && rose >= 10)
            {
                sumFlowers = sumFlowers - (sumFlowers * 10) / 100;
            }
            if (chrysanthemums + rose + tulips > 20)
            {
                sumFlowers = sumFlowers - (sumFlowers * 20) / 100;
            }
            Console.WriteLine("{0:f2}", sumFlowers + 2.00);
        }
    }
}
