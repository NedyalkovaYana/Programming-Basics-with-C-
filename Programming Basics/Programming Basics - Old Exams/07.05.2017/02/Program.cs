using System;

namespace _02
{
    class Program
    {
        static void Main()
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double puzzlesQuantity = double.Parse(Console.ReadLine());
            double dollsQuantity = double.Parse(Console.ReadLine());
            double teddyBearQuantity = double.Parse(Console.ReadLine());
            double minionQuantity = double.Parse(Console.ReadLine());
            double truckQuantity = double.Parse(Console.ReadLine());

            double sum = puzzlesQuantity * 2.6 +
                         dollsQuantity * 3 +
                         teddyBearQuantity * 4.10 +
                         minionQuantity * 8.2 +
                         truckQuantity * 2;

            double toysQuantity = puzzlesQuantity + dollsQuantity + teddyBearQuantity +
                minionQuantity + truckQuantity;

            if (toysQuantity >= 50)
            {
                sum -= sum * 0.25;
            }

            sum -= sum * 0.1;

            double isenouhht = Math.Abs(sum - holidayPrice);

            if (sum >= holidayPrice)
            {
                Console.WriteLine($"Yes! {isenouhht:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {isenouhht:F2} lv needed.");
            }
        }
    }
}
