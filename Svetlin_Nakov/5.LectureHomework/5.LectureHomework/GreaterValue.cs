using System;


namespace _5.LectureHomework
{
    class GreaterValue
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first nimber is greater than second number!");
                Console.WriteLine("Correct condition!");
            }
            else
            {
                Console.WriteLine("False!!!");
            }
        }
    }
}
