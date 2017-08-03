using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            decimal side = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal costOfTile = decimal.Parse(Console.ReadLine());
            decimal amountMaster = decimal.Parse(Console.ReadLine());

            decimal areaOfRectangle = width * length;
            decimal areaOfTriange = side * height / 2m;
            decimal numberTile = Math.Ceiling(areaOfRectangle / areaOfTriange) + 5m;


            decimal value = (numberTile * costOfTile) + amountMaster;

            decimal result = Math.Abs(money - value);

            if (money >= value)
            {
                Console.WriteLine($"{result:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {result:f2} lv more.");
            }
        }
    }
}
