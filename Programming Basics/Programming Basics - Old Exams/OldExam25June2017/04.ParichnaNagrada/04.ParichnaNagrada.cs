using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ParichnaNagrada
{
    class Program
    {
        static void Main()
        {
            int parts = int.Parse(Console.ReadLine());
            decimal moneyAward= decimal.Parse(Console.ReadLine());
            decimal sumPoints = 0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumPoints += points * 2;
                }
                else
                {
                    sumPoints += points;
                }
            }

            decimal awards = moneyAward * sumPoints;
            Console.WriteLine("The project prize was {0:f2} lv.", awards);
        }
    }
}
