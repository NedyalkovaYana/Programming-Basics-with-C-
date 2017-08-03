using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBricks = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int vmestimostNaKolichkata = int.Parse(Console.ReadLine());

            double obshtkurs = vmestimostNaKolichkata * people;
            double result = numberOfBricks / obshtkurs;
            Console.WriteLine(Math.Ceiling(result));

        }
    }
}
