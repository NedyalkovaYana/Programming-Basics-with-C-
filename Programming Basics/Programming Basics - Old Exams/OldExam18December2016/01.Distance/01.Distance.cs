using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTimeInMinute = double.Parse(Console.ReadLine());
            double secondTimeInMinute = double.Parse(Console.ReadLine());
            double thirdTimeInMinute = double.Parse(Console.ReadLine());

            double firstTimeHours = firstTimeInMinute / 60.00;
            double secondTimeHours = secondTimeInMinute / 60.00;
            double thirdTimeHours = thirdTimeInMinute / 60.00;


            double distanceWhitFirstTime = speed * firstTimeHours;
            double distanseAfterIncreace = speed + ((speed * 10) / 100);
            double distanceWhitSecondTime = distanseAfterIncreace * secondTimeHours;
            double distanceAfterDegree = distanseAfterIncreace - (distanseAfterIncreace * 5) / 100;
            double distanceWhitThirdTime = distanceAfterDegree * thirdTimeHours;

            double allSpeed = distanceWhitFirstTime + distanceWhitSecondTime + distanceWhitThirdTime;

            Console.WriteLine("{0:f2}", allSpeed);

        }
    }
}
