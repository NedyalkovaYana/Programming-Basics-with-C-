using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double secondsForDistance = distance * secondsForOneMeter;
            double MeterSlower = Math.Truncate(distance / 15);
            double secondsSlower = MeterSlower * 12.5;
            double allNeededTime = secondsForDistance + secondsSlower;

            if (allNeededTime <= record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", allNeededTime);
            }
            else
            {
                double moreNeededSeconds = allNeededTime - record;
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", moreNeededSeconds);
            }
        }
    }
}
