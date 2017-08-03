using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cups
{
    class Program
    {
        static void Main()
        {
            int cubs = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            double workingHours = workingDays * workers * 8;
            double workingCups = Math.Floor(workingHours / 5);

            if (workingCups >= cubs)
            {
                double enafCups = workingCups - cubs;
                double benefits = enafCups * 4.2;
                Console.WriteLine("{0:f2} extra money", benefits );
            }
            else if (workingCups < cubs)
            {
                double enafCups = cubs - workingCups;
                double missed = enafCups * 4.2;
                Console.WriteLine("Losses: {0:f2}", missed);
            }

        }
    }
}
