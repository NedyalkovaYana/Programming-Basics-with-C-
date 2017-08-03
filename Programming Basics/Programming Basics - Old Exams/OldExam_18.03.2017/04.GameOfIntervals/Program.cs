using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class Program
    {
        static void Main()
        {
            int moves = int.Parse(Console.ReadLine());
            double score = 0.0;
            double low = 0;
            double middle = 0;
            double average = 0;
            double high = 0;
            double above = 0;
            double invalidnum = 0;

            for (int i = 1; i <= moves; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (0<= numbers && numbers <=9)
                {
                    low++;
                    score += numbers * 0.2;
                }
                else if (10 <= numbers && numbers <= 19)
                {
                    middle++;
                    score += numbers * 0.3;
                }
                else if (20 <= numbers && numbers <= 29)
                {
                    average++;
                    score += numbers * 0.4;
                }
                else if (30 <= numbers && numbers <= 39)
                {
                    high++;
                    score += 50;
                }
                else if (40 <= numbers && numbers <= 50)
                {
                    above++;
                    score += 100;
                }
                else
                {
                    invalidnum++;
                    score = score / 2;
                }

            }
            double lowTotal = (low / moves) * 100;
            double middleTotal = (middle / moves) * 100;
            double averageTotal = (average / moves) * 100;
            double hightTotal = (high / moves) * 100;
            double aboveTotal = (above / moves) * 100;
            double invalidumTotal = (invalidnum / moves) * 100;

            Console.WriteLine("{0:f2}", score);
            Console.WriteLine("From 0 to 9: {0:f2}%", lowTotal);
            Console.WriteLine("From 10 to 19: {0:f2}%", middleTotal);
            Console.WriteLine("From 20 to 29: {0:f2}%", averageTotal);
            Console.WriteLine("From 30 to 39: {0:f2}%", hightTotal);
            Console.WriteLine("From 40 to 50: {0:f2}%", aboveTotal);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidumTotal);

        }
    }
}
