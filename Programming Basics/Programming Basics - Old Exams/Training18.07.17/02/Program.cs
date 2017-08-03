using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double twowalls = (a * (a / 2)) * 2;
            double square = ((a / 2) * (a / 2));
            double triangle = ((a / 2) *( b - (a/2)))/2;
            double backWall = square + triangle;
                
            double vhod = (a / 5) * (a / 5);
            double frontWall = backWall - vhod;
            double totalwallsArea = twowalls + backWall + frontWall;
            double greenPaint = totalwallsArea / 3;
            double roofArea = a * (a / 2) * 2;
            double redArea = roofArea / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redArea:f2}");

        }
    }
}
