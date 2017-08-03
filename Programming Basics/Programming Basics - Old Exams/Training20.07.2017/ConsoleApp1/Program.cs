using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDayInMonth = int.Parse(Console.ReadLine());
            decimal moneyForDay  = decimal.Parse(Console.ReadLine());
            decimal kursDolarLeva = decimal.Parse(Console.ReadLine());

            decimal salaryForOneMonth = workingDayInMonth * moneyForDay;
            decimal yearSalary = salaryForOneMonth * 12 + salaryForOneMonth * 2.5m;
            decimal salafyAfterdanuk = yearSalary - (yearSalary * 0.25m);
            decimal salaryInLeva = salafyAfterdanuk * kursDolarLeva;
            decimal averageSalaryForDay = salaryInLeva / 365;
            Console.WriteLine($"{averageSalaryForDay:f2}");

        }
    }
}
