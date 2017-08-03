using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int lozeArea = int.Parse(Console.ReadLine());
            double grozdeNaEdinKvadrat = double.Parse(Console.ReadLine());
            double neededLiterWine = double.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrape = lozeArea * grozdeNaEdinKvadrat;
            double wine = (0.4 * totalGrape)/ 2.5;

            if (wine < neededLiterWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLiterWine - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededLiterWine)} liters left -> {Math.Ceiling((wine - neededLiterWine)/workersCount)} liters per person.");
            }
            

        }
    }
}
