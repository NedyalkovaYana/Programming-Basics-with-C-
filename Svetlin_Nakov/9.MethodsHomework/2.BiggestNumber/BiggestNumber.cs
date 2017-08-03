using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BiggestNumber
{
    class BiggestNumber
    {   
        static void GetMax(int temp, int thirdNumber)
        {
            int biggerNumber = Math.Max(temp, thirdNumber);
            Console.WriteLine("The biggest number is: " + biggerNumber);
          

        }
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int temp = Math.Max(firstNumber, secondNumber);

            GetMax(temp, thirdNumber);

        }
    }
}
