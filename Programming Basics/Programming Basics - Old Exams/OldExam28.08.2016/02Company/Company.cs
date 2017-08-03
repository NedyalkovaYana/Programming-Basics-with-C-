using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Company
{
    class Company
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int avaliableDays = int.Parse(Console.ReadLine());
            int peopleWorkExtraordinary = int.Parse(Console.ReadLine());

            double bizzyTime = avaliableDays * 0.1;
            double hoursForWork = 8 * (avaliableDays - bizzyTime);
            double extraOurs = peopleWorkExtraordinary * (2 * avaliableDays);
            double allWorkTimes = Math.Floor(hoursForWork + extraOurs);
            double result = allWorkTimes - neededHours;

            if (allWorkTimes >= neededHours)
            {
                Console.WriteLine("Yes!{0} hours left.",result );
            }
            else
            {
                double notEnought = neededHours - allWorkTimes;
                Console.WriteLine("Not enough time!{0} hours needed.", notEnought);
            }


        }
    }
}
