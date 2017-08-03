using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Магазин_за_детски_играчки
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            double travelPrice = double.Parse(Console.ReadLine());
            double puzzleCount = double.Parse(Console.ReadLine());
            double dollCount = double.Parse(Console.ReadLine());
            double bearCount = double.Parse(Console.ReadLine());
            double minionCount = double.Parse(Console.ReadLine());
            double truckCount = double.Parse(Console.ReadLine());

            double moneyFromToys = puzzlePrice * puzzleCount +
                                   dollCount * dollPrice +
                                   bearPrice * bearCount +
                                   minionPrice * minionCount +
                                   truckPrice * truckCount;

            double amountOfToys = puzzleCount + dollCount + minionCount + truckCount + bearCount;

            if (amountOfToys >= 50)
            {
                moneyFromToys *= 0.75;
                
            }

            moneyFromToys *= 0.9;

            if (moneyFromToys >= travelPrice)
            {
                double rest = moneyFromToys - travelPrice;
                Console.WriteLine($"Yes! {rest:F2} lv left.");
            }
            else
            {
                double deficit = travelPrice - moneyFromToys;
                Console.WriteLine($"Not enough money! {deficit:F2} lv needed.");
            }
        }

    }
}