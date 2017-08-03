using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancerCount = int.Parse(Console.ReadLine());
            double tochkiCount = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double money = tochkiCount;
            

            switch (place)
            {
                case "bulgaria": money *= dancerCount; break;
                case "abroad": money += (tochkiCount - (tochkiCount * 0.5)); break;
            }
            switch (seasson)
            {
                case "summer":
                    if (place == "bulgaria")
                    {
                        money -= (money * 5) / 100;
                    }
                    else
	                {
                        money -= (money * 10) / 100; 
                    }
                    break;
                case "winter":
                    if (place == "bulgaria")
                    {
                        money -= (money * 8) / 100;
                    }
                    else
                    {
                        money -= (money * 15) / 100;
                    }
                    break;
            }
            double moneyForCharity = (money * 75) / 100;
            double restMoney = money - moneyForCharity;
            double moneyForDancer = restMoney / dancerCount;

            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancer:f2}");
        }
    }
}
