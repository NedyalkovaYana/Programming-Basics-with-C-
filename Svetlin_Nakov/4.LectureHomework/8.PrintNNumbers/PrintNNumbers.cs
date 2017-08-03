using System;


namespace _8.PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main()
        {
            double number;
            
            Console.WriteLine("Please enter the max number:");
            bool n = double.TryParse(Console.ReadLine(), out number);

           
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
}
