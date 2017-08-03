using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GrapeAndRakia
{
    class Program
    {
        static void Main()
        {
            double gardenArea = double.Parse(Console.ReadLine());
            double kgNaMeter = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double allGrape = gardenArea * kgNaMeter;
            double currentGrape = allGrape - brak;
            double grapeForRakia = (currentGrape * 45) / 100;
            double rakia = grapeForRakia / 7.5;
            double prihodOtRakia = rakia * 9.80;

            double zaProdan = (currentGrape * 55) / 100;
            double prihodOtGrape = zaProdan * 1.50;

            Console.WriteLine("{0:f2}", prihodOtRakia);
            Console.WriteLine("{0:f2}", prihodOtGrape);
        }
    }
}
