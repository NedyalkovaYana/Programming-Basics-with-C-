using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class Program
    {
        static void Main()
        {
            decimal savedMoney = decimal.Parse(Console.ReadLine());
            double wigth = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double hightOfTriangle = double.Parse(Console.ReadLine());
            decimal priceForOnePlate = decimal.Parse(Console.ReadLine());
            decimal moneyForMaster = decimal.Parse(Console.ReadLine());

            double floorArea = wigth * hight;
            double floorPlate = (sideOfTriangle * hightOfTriangle) / 2;
            double neededPlate = Math.Ceiling(floorArea / floorPlate) + 5;

            decimal totalSum = priceForOnePlate * (decimal)neededPlate + moneyForMaster;

            if (totalSum <= savedMoney)
            {
                decimal leftMoney = savedMoney - totalSum;
                Console.WriteLine("{0:f2} lv left.", leftMoney);
            }
            else
            {
                decimal neededMoney = totalSum - savedMoney;
                Console.WriteLine("You'll need {0:f2} lv more.", neededMoney);
            }


        }
    }
}
