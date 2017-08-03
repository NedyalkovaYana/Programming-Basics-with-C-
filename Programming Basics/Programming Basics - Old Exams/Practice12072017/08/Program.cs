using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollCount = int.Parse(Console.ReadLine());
            int tedyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.6;
            double talkingDollPrice = 3.0;
            double tedyBearPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2.0;

            double toysCount = puzzleCount + talkingDollCount + tedyBearCount
                               + minionCount + truckCount;
            double sumForAllToys = puzzleCount * puzzlePrice +
                                   talkingDollCount * talkingDollPrice +
                                   tedyBearCount * tedyBearPrice +
                                   minionCount * minionPrice +
                                   truckCount * truckPrice;

            if (toysCount >= 50)
            {
                sumForAllToys -= sumForAllToys * 0.25;
            }

            sumForAllToys -= sumForAllToys * 0.1;
            double leftMoney = Math.Abs(holidayPrice - sumForAllToys);

            if (sumForAllToys >= holidayPrice)
            {
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {leftMoney:f2} lv needed.");
            }
        }
    }
}
