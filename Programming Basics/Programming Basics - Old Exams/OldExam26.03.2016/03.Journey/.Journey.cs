using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Journey
{
    class Program
    {
        static void Main()
        {

            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (money <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double spentMoney = (money * 30) / 100;
                    Console.WriteLine("Camp - {0:f2}",spentMoney);
                }
                else if (season == "winter")
                {
                    double spentMoney = (money * 70) / 100;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else if (money > 100 && money <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double spentMoney = (money * 40) / 100;
                    Console.WriteLine("Camp - {0:f2}", spentMoney);
                }
                else if (season == "winter")
                {
                    double spentMoney = (money * 80) / 100;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else 
            {
                Console.WriteLine("Somewhere in Europe");
                double spentMoney = (money * 90) / 100;
                Console.WriteLine("Hotel - {0:f2}", spentMoney);
            }
        }
    }
}
