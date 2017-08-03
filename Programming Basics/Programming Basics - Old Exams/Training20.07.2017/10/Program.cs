using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)

        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string categories = Console.ReadLine().ToLower();
            decimal peopleCount = decimal.Parse(Console.ReadLine());
            decimal vipTicket = 499.99m;
            decimal normalTicket = 249.99m;

            if (peopleCount <= 4)        budget *= 0.25m;
            else if (peopleCount <= 9)   budget *= 0.4m;
            else if (peopleCount <= 24)  budget *= 0.5m;
            else if (peopleCount <= 49)  budget *= 0.6m;
            else if (peopleCount >= 50)  budget *= 0.75m;

            decimal sum = 0m;
            switch (categories)
            {
                case "normal": sum = normalTicket * peopleCount; break;
                case "vip": sum = vipTicket * peopleCount; break;
            }
            decimal isEnought = Math.Abs(budget - sum);
            if (sum < budget)
            {
                Console.WriteLine($"Yes! You have {isEnought:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {isEnought:f2} leva.");
            }
        }
    }
}
