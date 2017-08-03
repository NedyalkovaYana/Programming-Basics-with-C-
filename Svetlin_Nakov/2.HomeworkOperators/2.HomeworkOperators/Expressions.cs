using System;


namespace _2.HomeworkOperators
{
    class expressions
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number to see if it is odd or even");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) 
            {
                Console.WriteLine("The number is even");
            } 
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
