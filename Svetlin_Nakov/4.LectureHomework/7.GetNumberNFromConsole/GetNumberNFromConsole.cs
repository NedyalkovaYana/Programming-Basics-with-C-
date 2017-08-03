using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;



namespace _7.GetNumberNFromConsole
{
    class GetNumberNFromConsole
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            uint n;
            double sum = 0;
            double inputNumber;
            bool isValidEntry = true;
            Console.WriteLine("Enter the number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                for (int i = 0; i < n; i++)
                {
                    bool isInputNumberDouble = double.TryParse(Console.ReadLine(), out inputNumber);
                    if (isInputNumberDouble)
                    {
                        sum = sum + inputNumber;
                    }
                    else
                    {
                        Console.WriteLine("Not a number entry!");
                        isValidEntry = false;
                        break;
                    }
                }
                if (isValidEntry)
                {
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
