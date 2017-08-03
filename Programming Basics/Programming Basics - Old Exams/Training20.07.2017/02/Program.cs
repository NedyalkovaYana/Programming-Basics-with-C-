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
            int neededHours = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double hoursForWork = (daysForWork - (daysForWork * 0.1)) * 8;
            double extraHours = workersCount * (2 * daysForWork);
            double totalHours = Math.Floor(hoursForWork + extraHours);
            double enoughtHours = Math.Abs(neededHours - totalHours);

            if (totalHours >= neededHours)
            {
                Console.WriteLine($"Yes!{enoughtHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{enoughtHours} hours needed.");
            }

        }
    }
}
