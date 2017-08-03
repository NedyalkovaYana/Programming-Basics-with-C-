using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PlateReplacement
{
    class Program
    {
        static void Main()
        {
            double collectedMoney = double.Parse(Console.ReadLine());
            double wightFloor = double.Parse(Console.ReadLine());
            double hightFloor = double.Parse(Console.ReadLine());
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double hightOfTriangle = double.Parse(Console.ReadLine());
            double priceForOnePlate = double.Parse(Console.ReadLine());
            double moneyForMaster = double.Parse(Console.ReadLine());

            double floorArea = wightFloor * hightFloor;
            double plateArea = (sideOfTriangle * hightOfTriangle) / 2;
            double neededPlates = Math.Ceiling(floorArea / plateArea) + 5;

            double sum = (priceForOnePlate * neededPlates) + moneyForMaster;
            double leftSum = Math.Abs(collectedMoney - sum);

            if (collectedMoney >= sum)
            {
                Console.WriteLine($"{leftSum:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {leftSum:f2} lv more.");
            }



        }
    }
}
