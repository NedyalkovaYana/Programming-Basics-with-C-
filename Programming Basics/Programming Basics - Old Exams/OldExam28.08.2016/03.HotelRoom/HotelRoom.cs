using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioCostMayOctober = 50;
            double apartCostMayOctober = 65;
            double studioCostJuneSeptember = 75.20;
            double apartCostJuneSeptember = 68.70;
            double studioCostJulyAugust = 76;
            double apartCostJulyAugust = 77;

            double apartCostOverAll = 0;
            double studioCostOverAll = 0;

            switch (month)
            {
                case "may":
                case "october":
                    if (nights <= 7)
                    {
                        double apartMayOctober = nights * apartCostMayOctober;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartMayOctober);
                        double studioMayOctober = nights * studioCostMayOctober;
                        Console.WriteLine("Studio: {0:f2} lv.", studioMayOctober);
                    }
                    else if (nights > 7 && nights <= 14)
                    {
                        double apartMayOctober = nights * apartCostMayOctober;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartMayOctober);
                        studioCostOverAll = studioCostMayOctober - (studioCostMayOctober * 0.05);
                        double studioMayOctoberOtstupka = nights * studioCostOverAll;
                        Console.WriteLine("Studio: {0:f2} lv.", studioMayOctoberOtstupka);
                    }
                    else if (nights > 14)
                    {
                        apartCostOverAll = apartCostMayOctober - (apartCostMayOctober * 0.1);
                        double apartMayOctoberOtstupka = nights * apartCostOverAll;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartMayOctoberOtstupka);
                        studioCostOverAll = studioCostMayOctober - (studioCostMayOctober * 0.3);
                        double studioMayOctoerBigDiscount = nights * studioCostOverAll;
                        Console.WriteLine("Studio: {0:f2} lv.", studioMayOctoerBigDiscount);
                    }
                    break;
                case "june":
                case "september":
                    if (nights <= 14)
                    {
                        double apartJuneSeptember = nights * apartCostJuneSeptember;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartJuneSeptember);
                        double studioJuneSeptember = nights * studioCostJuneSeptember;
                        Console.WriteLine("Studio: {0:f2} lv.", studioJuneSeptember);
                    }
                    else
                    {
                        apartCostOverAll = apartCostJuneSeptember - (apartCostJuneSeptember * 0.1);
                        double apartJuneSeptemberDiscount = nights * apartCostOverAll;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartJuneSeptemberDiscount);
                        studioCostOverAll = studioCostJuneSeptember - (studioCostJuneSeptember * 0.2);
                        double studioJuneSeptemberDiscount = nights * studioCostOverAll;
                        Console.WriteLine("Studio: {0:f2} lv.", studioJuneSeptemberDiscount);

                    }
                    break;
                case "july":
                case "august":
                    if (nights <=14)
                    {
                        double apartJulyAugust = nights * apartCostJulyAugust;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartJulyAugust);
                        double studioJulyAugust = nights * studioCostJulyAugust;
                        Console.WriteLine("Studio: {0:f2} lv.", studioJulyAugust);

                    }
                    else
                    {
                        apartCostOverAll = apartCostJulyAugust - (apartCostJulyAugust * 0.1);
                        double apartJulyAugustDiscount = nights * apartCostOverAll;
                        Console.WriteLine("Apartment: {0:f2} lv.", apartJulyAugustDiscount);
                        double studioJulyAugustNoChange = nights * studioCostJulyAugust;
                        Console.WriteLine("Studio: {0:f2} lv.", studioJulyAugustNoChange);
                    }
                        break;
            }
        }
    }
}
