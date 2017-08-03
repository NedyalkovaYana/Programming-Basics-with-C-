using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPriceForKG = double.Parse(Console.ReadLine());
            double cacaPriceForKG = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());

            double palamudPrice = palamudKG * (skumriqPriceForKG +
                                  (skumriqPriceForKG * 0.6));
            double safridPrice = safridKG * (cacaPriceForKG +
                                 (cacaPriceForKG * 0.8));
            double midiPrice = midiKG * 7.5;

            double sum = palamudPrice + safridPrice + midiPrice;

            Console.WriteLine($"{sum:F2}");
            

        }
    }
}
