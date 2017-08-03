using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlowerMarket
{
    class Program
    {
        static void Main()
        {
            int soldHrizantema = int.Parse(Console.ReadLine());
            int soldRozi = int.Parse(Console.ReadLine());
            int soldLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string isHoliday = Console.ReadLine().ToLower();

            double hrizantemiSpringSummerPrice = 2.0;
            double hrizantemiAutunmWinterPrice = 3.75;
            double roziSpringSummerPrice = 4.10;
            double roziAutunmWinterPrice = 4.50;
            double laletaiSpringSummerPrice = 2.5;
            double laletaAutunmWinterPrice = 4.15;

            double flowerPrice = 0.0;
            double totalPrice = 0.0;
          
            double soldFlowers = soldLaleta + 
                                 soldHrizantema + 
                                 soldRozi;

            if (season == "spring" || season == "summer")
            {
                flowerPrice = soldHrizantema * hrizantemiSpringSummerPrice +
                              soldRozi * roziSpringSummerPrice +
                              soldLaleta * laletaiSpringSummerPrice;

                if (isHoliday == "y")
                {
                    flowerPrice += flowerPrice * 0.15;
                    if (soldLaleta > 7)
                    {
                        flowerPrice -= flowerPrice * 0.05;
                    }
                    if (soldFlowers > 20)
                    {
                        flowerPrice -= flowerPrice * 0.2;
                    }

                }

                totalPrice = flowerPrice + 2.0;
            }

            if (season == "autumn" || season == "winter")
            {
                flowerPrice = soldHrizantema * hrizantemiAutunmWinterPrice +
                              soldRozi * roziAutunmWinterPrice +
                              soldLaleta * laletaAutunmWinterPrice;

                if (isHoliday == "y")
                {
                    flowerPrice += flowerPrice * 0.15;
                    if (soldRozi > 10)
                    {
                        flowerPrice -= flowerPrice * 0.1;
                    }
                    if (soldFlowers > 20)
                    {
                        flowerPrice -= flowerPrice * 0.2;
                    }

                }

                totalPrice = flowerPrice + 2.0;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
