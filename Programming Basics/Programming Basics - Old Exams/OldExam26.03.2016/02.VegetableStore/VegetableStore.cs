using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VegetableStore
{
    class VegetableStore
    {
        static void Main(string[] args)
        {
            double priceKGBGvegetable = double.Parse(Console.ReadLine());
            double priceKGBGfruits = double.Parse(Console.ReadLine());
            int allKGvegetable = int.Parse(Console.ReadLine());
            int allKGfruits = int.Parse(Console.ReadLine());

            double moneyFromVeg = Math.Round((allKGvegetable * priceKGBGvegetable), 2);
            double moneyFromFru = Math.Round((allKGfruits * priceKGBGfruits), 2);
            double moneySum = moneyFromFru + moneyFromVeg;
            Console.WriteLine(moneySum / 1.94);
        }
    }
}
