using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniorBikersCount = double.Parse(Console.ReadLine());
            double seniorBikersCount = double.Parse(Console.ReadLine());
            string typeOfRoute = Console.ReadLine().ToLower();
            double afterFifty = 0;
            switch (typeOfRoute)
            {
                case "trail":
                    juniorBikersCount *= 5.5;
                    seniorBikersCount *= 7.0;
                    break;
                case "cross-country":
                    afterFifty = juniorBikersCount + seniorBikersCount;
                    juniorBikersCount *= 8.0;
                    seniorBikersCount *= 9.5;
                    break;
                case "downhill":
                    juniorBikersCount *= 12.25;
                    seniorBikersCount *= 13.75;
                    break;
                case "road":
                    juniorBikersCount *= 20.0;
                    seniorBikersCount *= 21.5;
                    break;
            }
            double subranaSuma = juniorBikersCount + seniorBikersCount;
            if (afterFifty >= 50)
            {
                subranaSuma -= subranaSuma * 0.25;
                subranaSuma -= subranaSuma * 0.05;
                Console.WriteLine($"{subranaSuma:f2}");
                return;
            }
            else
            {
                subranaSuma -= subranaSuma * 0.05;
                Console.WriteLine($"{subranaSuma:f2}");
            }
           
           
        }
    }
}
