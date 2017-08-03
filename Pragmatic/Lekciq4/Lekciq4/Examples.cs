using System;


namespace Lekciq4
{
    class Examples
    {
        static void Main()
        {
            string[] myArray = { "1", "2", "3", "4", "5" };

            foreach (var currentSTring in myArray)
            {
                Console.WriteLine(currentSTring);
            }


            for (int i = 0; i < length; i++)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
            }

            double firstNumber = 1433.55, secondNumber = 223425.33;
            double biggerNumber = MaxNumber(firstNumber, secondNumber);
            Console.WriteLine("Max number is: {0}", biggerNumber);


             static double MaxNumber(double num1, double num2)

             {
                double maxNumber;

                if (num1 > num2)
                {
                    MaxNumber = num1;

                }
                else
                {
                    MaxNumber = num2;
                }
                double maxNumber = (num1 > num2)
                    ? num1
                    : num2;

                //ili tova!!!!!!
                return (num1 > num2)
                    ? num1
                    : num2;

             }
        }
    }
}
