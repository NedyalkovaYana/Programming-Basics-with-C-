using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal dveteStranici = a * (a / 2) * 2;
            decimal square = (a / 2) * (a / 2);
            decimal triangle1= ((a / 2) * (h - (a/2)));
            decimal triangle2 = triangle1 / 2;
            decimal backWall = square + triangle2;
            decimal entry = a / 5;
            decimal vhod = entry * entry;
            decimal frontWall = backWall - vhod;
            decimal allAreaWalls = dveteStranici + backWall + frontWall;
            decimal greenPaint = allAreaWalls / 3;
            decimal roof = a * (a / 2) * 2;
            decimal redPaint = roof / 5;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);

        }
    }
}
