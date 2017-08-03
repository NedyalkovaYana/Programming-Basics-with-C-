using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieceOfProject = int.Parse(Console.ReadLine());
            double moneyForOnePoint = double.Parse(Console.ReadLine());
            double sumPoints = 0;
            double award = 0;
            for (int i = 1; i <= pieceOfProject; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumPoints += 2 * points;
                }
                else
                {
                    sumPoints += points;
                }
            }
            award = moneyForOnePoint * sumPoints;
            Console.WriteLine($"The project prize was {award:f2} lv.");
        }
    }
}
