using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int biitkoniCount = int.Parse(Console.ReadLine());
            decimal kitaiskiuanaCount = decimal.Parse(Console.ReadLine());
            decimal komission = decimal.Parse(Console.ReadLine());

            decimal biitkoniInLeva = biitkoniCount * 1168.0m;
            decimal kitaiskiUanaInDollars = kitaiskiuanaCount * 0.15m;
            decimal kitaiskiUanaVLeva = kitaiskiUanaInDollars * 1.76m;
            decimal totalSumInLeva = biitkoniInLeva + kitaiskiUanaVLeva;
            decimal totalSumInEvro = totalSumInLeva / 1.95m;
            decimal sumAfterKommision = totalSumInEvro - (totalSumInEvro * (komission/100));
            Console.WriteLine($"{sumAfterKommision:f2}");

        }
    }
}
