using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilisAge = int.Parse(Console.ReadLine());
            double washMashinePrice = double.Parse(Console.ReadLine());
            double priceForOneToy = double.Parse(Console.ReadLine());
            double moneyForEvenBirthday = 10.0;
            double currentSpentMoney = 0;
            double numberToys = 0;
            int count = 0;
            int brother = 0;

            for (int i = 1; i <= lilisAge; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    currentSpentMoney += count * moneyForEvenBirthday;
                    brother++;
                }
                else
                {
                    numberToys++;
                }
            }
            double priceForToys = priceForOneToy * numberToys;
            currentSpentMoney -= brother;
            double totalSum = priceForToys + currentSpentMoney;

            if (totalSum >= washMashinePrice)
            {
                Console.WriteLine($"Yes! {totalSum - washMashinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washMashinePrice - totalSum:f2}");
            }

        }
    }
}
