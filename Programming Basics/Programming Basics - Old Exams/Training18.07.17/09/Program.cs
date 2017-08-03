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
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal widthFloor = decimal.Parse(Console.ReadLine());
            decimal hightFloor = decimal.Parse(Console.ReadLine());
            decimal sideTriangle = decimal.Parse(Console.ReadLine());
            decimal hightTriangle = decimal.Parse(Console.ReadLine());
            decimal PriceForOnePlate = decimal.Parse(Console.ReadLine());
            decimal moneyForMaster = decimal.Parse(Console.ReadLine());

            decimal floorArea = widthFloor * hightFloor;
            decimal PlateArea = (sideTriangle * hightTriangle)/2;
            decimal neededPlates = Math.Ceiling(floorArea / PlateArea) + 5;

            decimal totalSum = (neededPlates * PriceForOnePlate) + moneyForMaster;

            decimal rest = Math.Abs(budget - totalSum);

            if (totalSum <= budget)
            {
                Console.WriteLine($"{rest:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {rest:f2} lv more.");
            }
        }
    }
}
