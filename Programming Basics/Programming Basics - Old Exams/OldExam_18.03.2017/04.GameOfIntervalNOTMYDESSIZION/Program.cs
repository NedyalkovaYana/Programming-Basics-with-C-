using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervalNOTMYDESSIZION
{
    class Program
    {
        static void Main(string[] args)
        {

            int moves = int.Parse(Console.ReadLine());


            double score = 0;
            double low = 0;
            double middle = 0;
            double average = 0;
            double high = 0;
            double above = 0;
            double invalidnum = 0;

            for (int i = 1; i <= moves; i++)
            {
                double numbers = double.Parse(Console.ReadLine());


                if (0 <= numbers && numbers <= 9)
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
            double lowtotal = (low / moves) * 100;
            double middletotal = (middle / moves) * 100;
            double averagetotal = (average / moves) * 100;
            double hightotal = (high / moves) * 100;
            double abovetotal = (above / moves) * 100;
            double invalidnumtotal = (invalidnum / moves) * 100;

            Console.WriteLine("{0:f2}", score);
            Console.WriteLine("From 0 to 9: {0:f2}%", lowtotal);
            Console.WriteLine("From 10 to 19: {0:f2}%", middletotal);
            Console.WriteLine("From 20 to 29: {0:f2}%", averagetotal);
            Console.WriteLine("From 30 to 39: {0:f2}%", hightotal);
            Console.WriteLine("From 40 to 50: {0:f2}%", abovetotal);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidnumtotal);
        }
    }
}
