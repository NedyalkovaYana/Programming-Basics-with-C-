using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main()
        {
            int numbersOfDays = int.Parse(Console.ReadLine());
            double leftFood = double.Parse(Console.ReadLine());
            double foodForDayDogKG = double.Parse(Console.ReadLine());
            double foodForDayCatKG = double.Parse(Console.ReadLine());
            double foodForDayTurtleGR = double.Parse(Console.ReadLine());

            double turtleFoodKG = foodForDayTurtleGR / 1000.0;

            double foodForAllAnimalDay = foodForDayCatKG + foodForDayDogKG + turtleFoodKG;
            double neededFoodForAllDays = numbersOfDays * foodForAllAnimalDay;

            if (neededFoodForAllDays <= leftFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Truncate(leftFood - neededFoodForAllDays));
            }
            else
            {
                double notEnought = Math.Ceiling(neededFoodForAllDays - leftFood);
                Console.WriteLine("{0} more kilos of food are needed.", notEnought);
            }

        }
    }
}
