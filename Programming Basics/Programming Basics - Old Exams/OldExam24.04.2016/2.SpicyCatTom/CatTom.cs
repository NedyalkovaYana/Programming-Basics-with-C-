using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SpicyCatTom
{
    class CatTom
    {
        static void Main(string[] args)
        {
            int freedays = int.Parse(Console.ReadLine());
            int tomWantToPlay = 30000;

            int workingDays = 365 - freedays;
            int timeForPlay = (workingDays * 63) + (freedays * 127);
            int differenceInNorm = Math.Abs(tomWantToPlay - timeForPlay);

            int hours = differenceInNorm / 60;
            int minutes = differenceInNorm % 60;

            if (tomWantToPlay > timeForPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else if (tomWantToPlay < timeForPlay)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }


        }
    }
}
