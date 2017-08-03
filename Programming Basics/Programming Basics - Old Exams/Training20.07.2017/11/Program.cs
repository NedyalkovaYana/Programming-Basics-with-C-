using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            double havingMoney = double.Parse(Console.ReadLine());
            double finalYear = double.Parse(Console.ReadLine());
            int currentYear = 18;
            
     
            for (int i = 1800; i <= finalYear; i++)
            {
                if (i % 2==0)
                {
                    havingMoney -= 12000;
                    
                }
                else
                {
                    havingMoney -= 12000 + (50 * currentYear);

                }
                currentYear++;
            }
            if (havingMoney >=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {havingMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(havingMoney):f2} dollars to survive.");
            }
        }
    }
}
