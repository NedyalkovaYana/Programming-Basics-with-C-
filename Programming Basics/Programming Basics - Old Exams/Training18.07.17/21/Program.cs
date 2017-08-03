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
            int days = int.Parse(Console.ReadLine());
            double ostavenaHranaVKG = double.Parse(Console.ReadLine());
            double foodDogOneDayKG = double.Parse(Console.ReadLine());
            double foodCatOneDayKG = double.Parse(Console.ReadLine());
            double foodTurtleOneDayGram = double.Parse(Console.ReadLine());
            double foodTurtleOneDayKG = foodTurtleOneDayGram / 1000.0;

            double allDogFood = days * foodDogOneDayKG;
            double allCatFood = days * foodCatOneDayKG;
            double allTurtleFood = days * foodTurtleOneDayKG;

            double allFood = allCatFood + allDogFood + allTurtleFood;

            if (ostavenaHranaVKG >= allFood)
            {
                double leftFood = Math.Floor(ostavenaHranaVKG - allFood);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(allFood - ostavenaHranaVKG);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }

        }
    }
}
