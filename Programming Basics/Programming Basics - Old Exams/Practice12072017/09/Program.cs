using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string gender = Console.ReadLine().ToLower();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            string sport = string.Empty;

            switch (season)
            {
                case "winter":
                    switch (gender)
                    {
                        case "boys": price = 9.6; sport = "Judo"; break;
                        case "girls": price = 9.6; sport = "Gymnastics"; break;
                        case "mixed": price = 10.0; sport = "Ski"; break;
                    }
                    break;
                case "spring":
                    switch (gender)
                    {
                        case "boys": price = 7.2; sport = "Tennis"; break;
                        case "girls": price = 7.2; sport = "Athletics"; break;
                        case "mixed": price = 9.5; sport = "Cycling"; break;
                    }
                    break;
                case "summer":
                    switch (gender)
                    {
                        case "boys": price = 15.0; sport = "Football"; break;
                        case "girls": price = 15.0; sport = "Volleyball"; break;
                        case "mixed": price = 20.0; sport = "Swimming"; break;
                    }
                    break;


            }

            double priceForNights = studentsCount * price * nights;

            if (studentsCount >= 50)
            {
                priceForNights -= priceForNights * 0.5;
            }
            else if (studentsCount >= 20)
            {
                priceForNights -= priceForNights * 0.15;
            }
            else if (studentsCount >= 10)
            {
                priceForNights -= priceForNights * 0.05;
            }

            Console.WriteLine($"{sport} {priceForNights:f2} lv.");
        }
    }
}
