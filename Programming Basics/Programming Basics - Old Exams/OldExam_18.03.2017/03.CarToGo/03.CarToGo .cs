using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            decimal taks = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "summer")
                {
                    taks = (budget * 35) / 100;
                    Console.WriteLine("Cabrio - {0:f2}", taks );
                }
                else if (season == "winter")
                {
                    taks = (budget * 65) / 100;
                    Console.WriteLine("Jeep - {0:f2}", taks);
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "summer")
                {
                    taks = (budget * 45) / 100;
                    Console.WriteLine("Cabrio - {0:f2}", taks);
                }
                else if (season == "winter")
                {
                    taks = (budget * 80) / 100;
                    Console.WriteLine("Jeep - {0:f2}", taks);
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                taks = (budget * 90) / 100;
                Console.WriteLine("Jeep - {0:f2}", taks);
                
            }
        }
    }
}
