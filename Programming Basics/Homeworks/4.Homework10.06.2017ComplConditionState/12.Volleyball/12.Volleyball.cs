using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double result = h + (48 - h) * 3 / 4 + p * 2 / 3;
            if (input == "leap")
            {
                result = (double)(result + (result * 15 / 100));
            }
            Console.WriteLine((int)result);

            //OR

            //var leapN = Console.ReadLine();
            //var praznici = double.Parse(Console.ReadLine());
            //var home = int.Parse(Console.ReadLine());
            //var sofWeek = 48 - home;
            //var SaturdayPlaySof = (sofWeek * 0.75);
            //var prazniciPlaySof = (praznici * 0.666666667);
            //var totalPlaysSofHome = SaturdayPlaySof + home + prazniciPlaySof;
            //if (leapN == "leap")
            //{
            //    var leapYear = (totalPlaysSofHome * 15) / 100;
            //    var leapYearPlays = totalPlaysSofHome + leapYear;
            //    Console.WriteLine(Math.Floor(leapYearPlays));
            //}
            //else
            //{
            //    Console.WriteLine(Math.Floor(totalPlaysSofHome));
            //}

        }
    }
}
