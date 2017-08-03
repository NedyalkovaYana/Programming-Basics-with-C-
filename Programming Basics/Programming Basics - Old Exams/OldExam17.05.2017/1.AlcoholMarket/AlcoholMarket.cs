using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main()
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double brandyQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

           
            double brandyPrice = whiskeyPrice / 2;
            double winePrice = brandyPrice - (0.4 * brandyPrice);
            double beerPrice = brandyPrice - (0.8 * brandyPrice);

            double brandySum = brandyQuantity * brandyPrice;
            double wineSum = wineQuantity * winePrice;
            double beerSum = beerQuantity * beerPrice;
            double whiskeySum = whiskeyQuantity * whiskeyPrice;

            double totalSum = brandySum + wineSum + beerSum + whiskeySum;
            Console.WriteLine("{0:F2}", totalSum);


        }
    }
}
