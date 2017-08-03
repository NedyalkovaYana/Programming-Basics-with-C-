using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double onePacketStyrofoam = double.Parse(Console.ReadLine());
            double priceOnePaketStyrofoam = double.Parse(Console.ReadLine());

            double areaWithoutWindows = houseArea - (windows * 2.4);
            double plusFira = areaWithoutWindows + (areaWithoutWindows * 0.1);
            double neededPaket =Math.Ceiling(plusFira / onePacketStyrofoam);
            double price = neededPaket * priceOnePaketStyrofoam;

            if (budget >= price)
            {
                double savedMoney = budget - price;
                Console.WriteLine("Spent: {0:f2}", price);
                Console.WriteLine("Left: {0:f2}", savedMoney);

            }
            else
	        {
                double notEnaough = Math.Abs(price - budget);
                Console.WriteLine("Need more: {0:f2}", notEnaough ); 
            }

        }
    }
}
