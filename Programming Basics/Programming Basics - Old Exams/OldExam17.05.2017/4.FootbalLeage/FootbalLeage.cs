using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FootbalLeage
{
    class FootbalLeage
    {
        static void Main()
        {
            double capacityOfFens = double.Parse(Console.ReadLine());
            double numberOfFans = double.Parse(Console.ReadLine());
            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
            for (int i = 0; i < numberOfFans; i++)
            {
                string sektor = Console.ReadLine();

                switch (sektor)
                {
                    case "A":
                        fansA = fansA + 1;
                        break;
                    case "B":
                        fansB = fansB + 1;
                        break;
                    case "V":
                        fansV = fansV + 1;
                        break;
                    case "G":
                        fansG = fansG + 1;
                        break;

                }
            }
            fansA = (fansA /numberOfFans) * 100;
            fansB = (fansB / numberOfFans) * 100;
            fansV = (fansV / numberOfFans) * 100;
            fansG = (fansG / numberOfFans) * 100;
            numberOfFans = (numberOfFans / capacityOfFens) * 100;

            Console.WriteLine("{0:F2}%", fansA);
            Console.WriteLine("{0:F2}%", fansB);
            Console.WriteLine("{0:F2}%", fansV);
            Console.WriteLine("{0:F2}%", fansG);
            Console.WriteLine("{0:F2}%", numberOfFans);
        }
    }
}
