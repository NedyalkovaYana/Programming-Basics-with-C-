using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double lozeArea = double.Parse(Console.ReadLine());
            double kgIzkaraniNaKvadrat = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double kgIzkaranoGrozde = lozeArea * kgIzkaraniNaKvadrat;
            double kgAfterBrak = kgIzkaranoGrozde - brak;
            double kgGrozdeZaRakia = kgAfterBrak * 0.45;
            double litriZaRakia = kgGrozdeZaRakia / 7.5;
            double prihodOtRakia = litriZaRakia * 9.8;

            double kgGrozdeZaProdan = kgAfterBrak * 0.55;
            double prihodOtGrozde = kgGrozdeZaProdan * 1.5;

            Console.WriteLine($"{prihodOtRakia:f2}");
            Console.WriteLine($"{prihodOtGrozde:f2}");

        }
    }
}
