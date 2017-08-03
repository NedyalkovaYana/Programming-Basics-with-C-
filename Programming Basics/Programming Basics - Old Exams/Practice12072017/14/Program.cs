using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            double windowsCount = double.Parse(Console.ReadLine());
            double KVMstiroporEdinPaket = double.Parse(Console.ReadLine());
            double PriceForOnePaket = double.Parse(Console.ReadLine());

            double freeHouseArea = houseArea - windowsCount * 2.4;
            freeHouseArea += freeHouseArea * 0.1;
            double neededPaket = Math.Ceiling(freeHouseArea/KVMstiroporEdinPaket);
            double priceForStiropor = neededPaket * PriceForOnePaket;
            double leftMoney = Math.Abs(budget - priceForStiropor);

            if (priceForStiropor <= budget)
            {
                Console.WriteLine($"Spent: {priceForStiropor:f2}");
                Console.WriteLine($"Left: {leftMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {leftMoney:f2}");
            }
        }
    }
}
