using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class TrainingLab
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = a * 100;
            double w = (b * 100) - 100;
            double row = Math.Floor(h / 120);
            double col = Math.Floor(w / 70);

            //if ((3 <= h) && (w <= 100))

            double workingPlace = (row * col) - 3;
            Console.WriteLine(workingPlace);
        }
    }
}
