using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string classCar = string.Empty;
            string modelCar = string.Empty;

            if (budget <= 100)
            {
                classCar = "Economy class";
                switch (season)
                {
                    case "summer": budget *= 0.35; modelCar = "Cabrio"; break;
                    case "winter": budget *= 0.65; modelCar = "Jeep"; break;

                }
            }
            else if (budget <= 500)
            {
                classCar = "Compact class";
                switch (season)
                {
                    case "summer": budget *= 0.45; modelCar = "Cabrio"; break;
                    case "winter": budget *= 0.8; modelCar = "Jeep"; break;

                }
            }
            else if (budget > 500)
            {
                classCar = "Luxury class";
                switch (season)
                {
                    case "summer": 
                    case "winter": budget *= 0.9; modelCar = "Jeep"; break;

                }
            }
            Console.WriteLine(classCar);
            Console.WriteLine($"{modelCar} - {budget:f2}");
        }
    }
}
