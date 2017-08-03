using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums3Numbers
{
    class Sums3Numbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            //int biggestNumber = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            //int smallestNumber = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            //int middle = 0;
            if (firstNumber + secondNumber == thirdNumber)
            {
                if (firstNumber >= secondNumber)
                {
                    Console.WriteLine("{0} + {1} = {2}", secondNumber, firstNumber, thirdNumber);
                }
                else if (secondNumber > firstNumber )
                {
                    Console.WriteLine("{0} + {1} = {2}",  firstNumber, secondNumber, thirdNumber);
                }
                
            }
            if (firstNumber + thirdNumber == secondNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} + {1} = {2}", thirdNumber, firstNumber, secondNumber);
                }
                else if (thirdNumber > firstNumber)
                {
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            if (secondNumber + thirdNumber == firstNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} + {1} = {2}", thirdNumber, secondNumber, firstNumber);
                }
                else if (thirdNumber > secondNumber)
                {
                    Console.WriteLine("{0} + {1} = {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
