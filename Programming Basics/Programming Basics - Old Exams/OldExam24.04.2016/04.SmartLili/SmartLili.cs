using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLili
{
    class SmartLili
    {
        static void Main()
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double priceWashingMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            var toys = 0;
            var brother = 0;
            double sum = 0;
            var count = 0;
            double result = 0;


            for (int i = 1; i <= lilysAge; i++)
            {
                if (i % 2 == 0)
                {

                    count = 10 * ((i + 1) / 2);
                    sum = sum + count;

                    brother++;
                    
                }
                else
                {
                    toys ++;
                }
            }
            
            var moneyFromToys = toys * toyPrice;
            sum = sum + moneyFromToys - brother;
          
            result = Math.Abs(sum - priceWashingMashine);
            if (sum >= priceWashingMashine)
            {
                
                Console.WriteLine("Yes! {0:f2}", result);
            }
            else
            {
                
                Console.WriteLine("No! {0:f2}", result);
            }
        }
    }
}
