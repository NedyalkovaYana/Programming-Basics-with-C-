using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            double stepsNumber = double.Parse(Console.ReadLine());

            double dancerCount = double.Parse(Console.ReadLine());
            double daysForTraining = double.Parse(Console.ReadLine());

            double stepsForDay = Math.Ceiling((stepsNumber / daysForTraining) / stepsNumber);
        }
    }
}
