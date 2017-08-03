using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrisantemiumCount = int.Parse(Console.ReadLine());
            int roziCount = int.Parse(Console.ReadLine());
            int laletaCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string isHoliday = Console.ReadLine().ToLower();

            double chrisantemiumPrise =
                (season == "spring" || season == "summer") ? 2.0 : 3.75;
            double rosePrice =
                 (season == "spring" || season == "summer") ? 4.1 : 4.5;
            double laletaPrice = 
               (season == "spring" || season == "summer") ? 2.5 : 4.15;

            double flowerPrice = chrisantemiumCount * chrisantemiumPrise +
                                 roziCount * rosePrice +
                                 laletaPrice * laletaCount;
            double totalFlowerCount = chrisantemiumCount +
                                      roziCount +
                                      laletaCount;
            if (isHoliday == "y")
            {
                flowerPrice += flowerPrice * 0.15;
            }
            if (laletaCount > 7 && season == "spring")
            {
                flowerPrice -= flowerPrice * 0.05;
            }
            if (roziCount >= 10 && season == "winter")
            {
                flowerPrice -= flowerPrice * 0.1;
            }
            if (totalFlowerCount > 20)
            {
                flowerPrice -= flowerPrice * 0.2;
            }

            flowerPrice += 2;
            Console.WriteLine($"{flowerPrice:f2}");
        }
    }
}
