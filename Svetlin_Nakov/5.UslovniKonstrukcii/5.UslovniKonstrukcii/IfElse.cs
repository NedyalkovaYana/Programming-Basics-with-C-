using System;


namespace _5.UslovniKonstrukcii
{
    class IfElse
    {
        static void Main()
        {
            
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number>0)
            {
                Console.WriteLine("The number is positive!");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is zero!");
            }
            else
            {
                Console.WriteLine("The number is negative!");
            }
            
        }
    }
}
