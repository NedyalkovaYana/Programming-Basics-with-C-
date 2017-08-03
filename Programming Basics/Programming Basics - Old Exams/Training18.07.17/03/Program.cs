using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHour = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int workingHours = workersCount * workingDays * 8;

            int razlika = Math.Abs(workingHours - neededHour);
            int neustoiki = razlika * workingDays;
            if (workingHours >= neededHour)
            {
                Console.WriteLine($"{razlika} hours left");
            }
            else
            {
                Console.WriteLine($"{razlika} overtime");
                Console.WriteLine($"Penalties: {neustoiki}");
            }
        }
    }
}
