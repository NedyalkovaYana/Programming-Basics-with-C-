using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class BackToThePast
    {
        static void Main()
        { 
            double money = double.Parse(Console.ReadLine());
            int finalYear = int.Parse(Console.ReadLine());
            int count = 18;
            for (int year = 1800; year <= finalYear; year++)
            {
               
                if (year % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + (50 * count);
                }
                count++;
            }
            
            if (money >=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
