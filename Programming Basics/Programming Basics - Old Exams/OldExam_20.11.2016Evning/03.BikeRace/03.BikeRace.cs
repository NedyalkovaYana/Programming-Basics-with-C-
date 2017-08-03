using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main()
        {
            int juniorBikersNumber = int.Parse(Console.ReadLine());
            int seniorBikersNumber = int.Parse(Console.ReadLine());
            string rout = Console.ReadLine().ToLower();
            double juniorSum;
            double seniorSum;
            double taksSum;
            double razhodi;
            double darenaSuma;


            if (rout == "trail")
            {
                juniorSum = juniorBikersNumber * 5.50;
                seniorSum = seniorBikersNumber * 7.0;
                taksSum = juniorSum + seniorSum;
                razhodi = (taksSum * 5) / 100;
                darenaSuma = taksSum - razhodi;
                Console.WriteLine("{0:f2}", darenaSuma);
            }
            else if (rout == "cross-country")
            {
                int allSportist = juniorBikersNumber + seniorBikersNumber;
                if (allSportist >= 50)
                {
                    juniorSum = juniorBikersNumber * 8.0;
                    seniorSum = seniorBikersNumber * 9.50;
                    taksSum = juniorSum + seniorSum;
                    double otstupkaGrupa = taksSum - (taksSum * 25) / 100;
                    razhodi = (otstupkaGrupa * 5) / 100;
                    darenaSuma = otstupkaGrupa - razhodi;
                    Console.WriteLine("{0:f2}", darenaSuma);
                }
                else
                {
                    juniorSum = juniorBikersNumber * 8.0;
                    seniorSum = seniorBikersNumber * 9.50;
                    taksSum = juniorSum + seniorSum;                  
                    razhodi = (taksSum * 5) / 100;
                    darenaSuma = taksSum - razhodi;
                    Console.WriteLine("{0:f2}", darenaSuma);
                }
            }
            else if (rout == "downhill")
            {
                juniorSum = juniorBikersNumber * 12.25;
                seniorSum = seniorBikersNumber * 13.75;
                taksSum = juniorSum + seniorSum;
                razhodi = (taksSum * 5) / 100;
                darenaSuma = taksSum - razhodi;
                Console.WriteLine("{0:f2}", darenaSuma);
            }
            else if (rout == "road")
            {
                juniorSum = juniorBikersNumber * 20.0;
                seniorSum = seniorBikersNumber * 21.50;
                taksSum = juniorSum + seniorSum;
                razhodi = (taksSum * 5) / 100;
                darenaSuma = taksSum - razhodi;
                Console.WriteLine("{0:f2}", darenaSuma);

            }

        }
    }
}
