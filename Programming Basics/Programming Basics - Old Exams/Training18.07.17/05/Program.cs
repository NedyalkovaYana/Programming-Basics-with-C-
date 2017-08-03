using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double hodove = int.Parse(Console.ReadLine());
            
            double result = 0;
            int countTo9 = 0;
            int countTo19 = 0;
            int countTo29 = 0;
            int countTo39 = 0;
            int countTo50 = 0;
            int invalid = 0;
            for (int i = 1; i <= hodove; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 50 || number < 0)
                {
                    invalid++;
                    result /= 2;
                }
               else if (number <= 9)
                {
                    countTo9++;
                    result += number * 0.2;
                }
                else if (number <= 19)
                {
                    countTo19++;
                    result += number * 0.3;
                }
                else if (number <= 29)
                {
                    countTo29++;
                    result += number * 0.4;
                }
                else if (number <= 39)
                {
                    countTo39++;
                    result += 50;
                }
                else if (number <= 50)
                {
                    countTo50++;
                    result += 100;
                }
                

            }

            double presentTo9 = (countTo9 / hodove) * 100;
            double presentTo19 = (countTo19 / hodove) * 100;
            double presentTo29 = (countTo29 / hodove) * 100;
            double presentTo39 = (countTo39 / hodove) * 100;
            double presentTo50 = (countTo50 / hodove) * 100;
            double presentInvalid = (invalid / hodove) * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {presentTo9:f2}%");
            Console.WriteLine($"From 10 to 19: {presentTo19:f2}%");
            Console.WriteLine($"From 20 to 29: {presentTo29:f2}%");
            Console.WriteLine($"From 30 to 39: {presentTo39:f2}%");
            Console.WriteLine($"From 40 to 50: {presentTo50:f2}%");
            Console.WriteLine($"Invalid numbers: {presentInvalid:f2}%");
        }
    }
}
