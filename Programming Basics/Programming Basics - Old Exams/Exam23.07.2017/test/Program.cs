using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancerCount = int.Parse(Console.ReadLine());
            double tochki = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double money = 0.0;

            switch (place)
            {
                case "bulgaria": money = tochki * dancerCount; break;
                case "abroad": money = (tochki * dancerCount) + ((tochki * dancerCount) * 0.5);break;
            }

            double razhodi = 0.0;
            switch (season)
            {
                case "summer":
                    if (place == "bulgaria")
                    {
                        razhodi = money - ((money * 5)/100);
                    }
                    else
                    {
                        razhodi =money - ((money * 10) / 100);
                    }
                    break;
                case "winter":
                    if (place == "bulgaria")
                    {
                        razhodi = money - ((money * 8) / 100);
                    }
                    else
                    {
                        razhodi = money - ((money * 15) / 100);
                    }
                    break;

            }
            double moneyForCharity =(razhodi * 75) / 100;
            double leftMoneyAfterCharity = razhodi - moneyForCharity;
            double moneyForDancer = leftMoneyAfterCharity / dancerCount;

            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancer:f2}");
        }
    }
}
