using System;


namespace _5.PrintGreaterValue
{
    class PrintGreaterValue
    {
        static void Main()
        {

            double a, b;
            Console.WriteLine("Please enter the number a:");
            bool isaDouble = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please enter the number b:");
            bool isbDouble = double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("The greater number between a and b is: {0}", Math.Max(a, b));
           

        }
    }
}
