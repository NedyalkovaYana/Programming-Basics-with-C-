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
            double stepsNumber = double.Parse(Console.ReadLine());
            double dancerCount = double.Parse(Console.ReadLine());
            double daysForTraining = double.Parse(Console.ReadLine());

            double stepsForOneDay =(stepsNumber / daysForTraining) / stepsNumber;
            double stepsForDay = Math.Ceiling(stepsForOneDay * 100);
            double procentStepsForanyDancer = stepsForDay / dancerCount;

            double totalProcentSteps = dancerCount * procentStepsForanyDancer;


            if (totalProcentSteps <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {procentStepsForanyDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {procentStepsForanyDancer:f2}% steps to be learned per day.");
            }
           

        }
    }
}
