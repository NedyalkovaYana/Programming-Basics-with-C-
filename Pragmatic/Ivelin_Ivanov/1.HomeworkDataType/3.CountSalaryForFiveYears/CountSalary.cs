using System;


namespace _3.CountSalaryForFiveYears
{
    class CountSalary
    {
        static void Main()
        {

            Console.WriteLine("Please, enter current salary:");
            decimal currentSalary = decimal.Parse(Console.ReadLine());

            decimal salaryForFiveYears = (currentSalary * 60);
            Console.WriteLine("Salary for five years is: {0}", salaryForFiveYears);
                

        }
    }
}
