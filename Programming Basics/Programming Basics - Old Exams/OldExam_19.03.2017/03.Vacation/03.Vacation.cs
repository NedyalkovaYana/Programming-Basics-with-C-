using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();
            decimal money = 0;

            if (budget <= 1000)
            {
               
                if (seasson == "summer")
                {
                    money = ((budget * 65) / 100);

                    Console.Write("Alaska - Camp - {0:f2}", money);
                }
                else if (seasson == "winter")
                {
                    money = ((budget * 45) / 100);

                    Console.Write("Morocco - Camp - {0:f2}", money);
                }
                
            }
           else if (budget > 1000 && budget <= 3000 )
            {

                if (seasson == "summer")
                {
                    money = ((budget * 80) / 100);

                    Console.Write("Alaska - Hut - {0:f2}", money);
                }
                else if (seasson == "winter")
                {
                    money =((budget * 60) / 100);

                    Console.Write("Morocco - Hut - {0:f2}", money);
                }

            }
            else if (budget > 3000)
            {

                if (seasson == "summer")
                {
                    money =((budget * 90) / 100);

                    Console.Write("Alaska - Hotel - {0:f2}", money);
                }
                else if (seasson == "winter")
                {
                    money = ((budget * 90) / 100);

                    Console.Write("Morocco - Hotel - {0:f2}", money);
                }

            }
            Console.WriteLine();
        }
    }
}
