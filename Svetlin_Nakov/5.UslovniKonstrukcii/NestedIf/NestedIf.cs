using System;


namespace NestedIf
{
    class NestedIf
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers (on separate lines): ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers is equal!");

            }
            else
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("The first number is greater!");
                }

                else
                {
                    Console.WriteLine("The second number is greater!");
                }
            }
        }
    }
}


