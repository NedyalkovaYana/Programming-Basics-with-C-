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
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string sleepPlace = String.Empty;
            string place = String.Empty;
            if (budget <= 1000)
            {
                sleepPlace = "Camp";
                switch (season)
                {
                  case "summer": budget = budget * 0.65;  place = "Alaska"; break;
                  case "winter": budget = budget * 0.45; place = "Morocco"; break;
                }
            }
            else if (budget <= 3000)
            {
                sleepPlace = "Hut";
                switch (season)
                {
                    case "summer": budget = budget * 0.8; place = "Alaska"; break;
                    case "winter": budget = budget * 0.6; place = "Morocco"; break;
                }
            }
            else if (budget > 3000)
            {
                sleepPlace = "Hotel";
                switch (season)
                {
                    case "summer": budget = budget * 0.9; place = "Alaska"; break;
                    case "winter": budget = budget * 0.9; place = "Morocco"; break;
                }
            }
            Console.WriteLine($"{place} - {sleepPlace} - {budget:f2}");
        }
    }
}
