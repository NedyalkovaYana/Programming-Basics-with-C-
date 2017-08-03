using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());
            double swimmingSecForDistance = distanceInMeters * secondsForOneMeter;
            double slower = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = swimmingSecForDistance + slower;

            double allTime = Math.Abs(record - totalTime);

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {allTime:f2} seconds slower.");
            }


        }
    }
}
