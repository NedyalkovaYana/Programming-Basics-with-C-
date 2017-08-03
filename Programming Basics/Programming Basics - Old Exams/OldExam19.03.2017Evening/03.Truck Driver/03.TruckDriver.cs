using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Truck_Driver
{
    class Program
    {
        static void Main()
        {
            string seasson = Console.ReadLine().ToLower();
            double kilometersForMonth = double.Parse(Console.ReadLine());
            double monthSalary = 0.0;
            double finalSalary = 0.0;
            double salaryAfterTaks;

            if (seasson == "spring" || seasson == "autumn")
            {
                if (kilometersForMonth <= 5000)
                {
                    monthSalary = kilometersForMonth * 0.75;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
                else if (kilometersForMonth > 5000 && kilometersForMonth <= 10000)
                {
                    monthSalary = kilometersForMonth * 0.95;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
            }
            else if (seasson == "summer")
            {
                if (kilometersForMonth <= 5000)
                {
                    monthSalary = kilometersForMonth * 0.90;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
                else if (kilometersForMonth > 5000 && kilometersForMonth <= 10000)
                {
                    monthSalary = kilometersForMonth * 1.10;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
            }
            else if (seasson == "winter")
            {
                if (kilometersForMonth <= 5000)
                {
                    monthSalary = kilometersForMonth * 1.05;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
                else if (kilometersForMonth > 5000 && kilometersForMonth <= 10000)
                {
                    monthSalary = kilometersForMonth * 1.25;
                    finalSalary = monthSalary * 4;
                    salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                    Console.WriteLine("{0:f2}", salaryAfterTaks);
                }
            }
            if (kilometersForMonth > 10000 && kilometersForMonth <= 20000)
            {
                monthSalary = kilometersForMonth * 1.45;
                finalSalary = monthSalary * 4;
                salaryAfterTaks = finalSalary - (finalSalary * 10) / 100;
                Console.WriteLine("{0:f2}", salaryAfterTaks);
            }
        }
    }
}
