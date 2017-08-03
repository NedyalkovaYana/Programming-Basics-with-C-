using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main()
        {
            double priceSkumriqKG = double.Parse(Console.ReadLine());
            double priceCacaKG = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());

            double palamudPrice = priceSkumriqKG  + priceSkumriqKG * 0.6;
            double sumPalamud = palamudKG * palamudPrice;
            double safridiPrice = priceCacaKG + priceCacaKG * 0.8;
            double sumSafridi = safridKG * safridiPrice;
            double midiPrice = midiKG * 7.50;

            double neededMoney = sumPalamud + sumSafridi + midiPrice;
            Console.WriteLine("{0:f2}", neededMoney);

        }
    }
}
