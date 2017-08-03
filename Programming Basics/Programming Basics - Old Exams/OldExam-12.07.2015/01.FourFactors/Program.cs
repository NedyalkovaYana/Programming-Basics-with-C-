using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            double fg = double.Parse(Console.ReadLine());
            double fga = double.Parse(Console.ReadLine());
            double _3p = double.Parse(Console.ReadLine());
            double tov = double.Parse(Console.ReadLine());
            double orb = double.Parse(Console.ReadLine());
            double oopDrb = double.Parse(Console.ReadLine());
            double ft = double.Parse(Console.ReadLine());
            double fta = double.Parse(Console.ReadLine());

            double eFG = (fg + 0.5 * _3p) / fga;
            double TOV = tov / (fga + 0.44 * fta + tov);
            double ORB = (orb) / (orb + oopDrb);
            double FT = ft / fga;

            Console.WriteLine($"eFG% {eFG:f3}");
            Console.WriteLine($"TOV% {TOV:f3}");
            Console.WriteLine($"ORB% {ORB:f3}");
            Console.WriteLine($"FT% {FT:f3}");
        }
    }
}
