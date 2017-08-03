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
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double distanceWhitFirstSpeed = firstSpeed * (firstTime / 60.0);
            double distanceIncrease =
                firstSpeed + (firstSpeed* 0.1);
            double increaseInHours = distanceIncrease * (secondTime / 60.0);
            double distanceDecrease = distanceIncrease * 0.95;
            double distanceDecreaseInHour =
                distanceDecrease * (thirdTime / 60.0);
            double totalDistance = distanceWhitFirstSpeed +
                     increaseInHours + distanceDecreaseInHour;
            Console.WriteLine($"{totalDistance:f2}");

        }
    }
}
