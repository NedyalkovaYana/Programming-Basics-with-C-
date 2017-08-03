using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePainting
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //steni
            double stranichnaStena = x * y;
            double prozorec = 1.5 * 1.5;
            double dveteStranici = 2 * stranichnaStena - 2 * prozorec;
            double zadnaStena = x * x;
            double vhod = 1.2 * 2;
            double dvetePrednaIZadna = zadnaStena * 2 - vhod;
            double totalArea = dvetePrednaIZadna + dveteStranici;
            double greenPaint = totalArea / 3.4;

            //pokriv
            double pravougulnici = 2 * (x * y);
            double triangles = 2 * ((x * h) / 2);
            double totalAreaPokriv = pravougulnici + triangles;
            double redPaint = totalAreaPokriv / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);


        }
    }
}
