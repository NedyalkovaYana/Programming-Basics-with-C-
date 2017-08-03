using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int lozeArea = int.Parse(Console.ReadLine());
            double grapeForOneKVm = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrape = lozeArea * grapeForOneKVm;
            double wine = 0.4 * totalGrape / 2.5;
            
            if (wine >= neededLitersWine)
            {

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine - neededLitersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededLitersWine)} liters left -> {Math.Ceiling((wine - neededLitersWine)/ workersCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine - wine)} liters wine needed.");
            }
        }
    }
}
