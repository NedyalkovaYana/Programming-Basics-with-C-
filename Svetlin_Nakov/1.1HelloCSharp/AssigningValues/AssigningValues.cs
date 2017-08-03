using System;


namespace AssigningValues
{
    class AssigningValues
    {
        static void Main()
        {
            int firstValue = 5;
            int secondValue;
            int thirdValue;

            secondValue = firstValue;
            thirdValue = firstValue = 3;

            int num = new int();
            float heightInMeters = 1.74f;
            string greeting = "Hello World";
            string message = greeting;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", firstValue, secondValue, thirdValue, num, heightInMeters, greeting, message);
        }
    }
}
