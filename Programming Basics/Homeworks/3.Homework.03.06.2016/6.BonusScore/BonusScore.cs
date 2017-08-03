using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (number <= 100)
            {
                bonusPoints = 5;

            }
            else if ((number > 100) && (number <= 1000))
            {
                bonusPoints = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusPoints = number * 0.1;
            }

            bool fivePointsExtra = (number % 10 == 5);

            if (number % 2 == 0)
            {
               bonusPoints += 1;
            }
            else if (fivePointsExtra)
            {
                bonusPoints += 2;
            }

            double finalResult = number + bonusPoints;
            Console.WriteLine("{0}", bonusPoints);
            Console.WriteLine("{0}", finalResult);
        }
    }
}
