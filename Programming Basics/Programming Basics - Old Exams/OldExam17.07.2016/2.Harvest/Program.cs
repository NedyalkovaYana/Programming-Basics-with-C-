using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaOfVineyard = int.Parse(Console.ReadLine());
            double grapesForSquaremetr = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int numberOfEmployers = int.Parse(Console.ReadLine());

            double allGrapes = areaOfVineyard * grapesForSquaremetr;
            double litersWine = 0.4 * allGrapes / 2.5;

            if (litersWine >= neededLitersWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", 
                    Math.Truncate(litersWine));

                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(litersWine - neededLitersWine),
                    Math.Ceiling((litersWine - neededLitersWine) / numberOfEmployers));
            }
            else if (litersWine < neededLitersWine)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(neededLitersWine - litersWine));
            }
           

        }
    }
}
