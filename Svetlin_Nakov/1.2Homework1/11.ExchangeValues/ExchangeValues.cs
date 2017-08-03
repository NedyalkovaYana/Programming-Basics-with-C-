using System;


namespace _11.ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int firstValue = 5;
            int secondValue = 10;
            int changeValue;

            changeValue = firstValue;
            firstValue = secondValue;
            secondValue = changeValue;
            Console.WriteLine("{0}\n{1}\n{2}",firstValue,secondValue,changeValue);



        }
    }
}
