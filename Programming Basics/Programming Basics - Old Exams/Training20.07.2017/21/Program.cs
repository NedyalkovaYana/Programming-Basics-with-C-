using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            double lozeArea = double.Parse(Console.ReadLine());
            double grozdeForOneKV = double.Parse(Console.ReadLine());
            double neededWine = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());

            double grozdeForAllLove = lozeArea * grozdeForOneKV;
            double littersWine = (grozdeForAllLove * 0.4) / 2.5;

            if (littersWine < neededWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - littersWine)} liters wine needed.");
            }
            else
            {
                double leftWine = Math.Ceiling(littersWine - neededWine);
                double forWorkers = Math.Ceiling(leftWine / workersCount);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(littersWine)} liters.");
                Console.WriteLine($"{leftWine} liters left -> {forWorkers} liters per person.");
            }
        }
    }
}
