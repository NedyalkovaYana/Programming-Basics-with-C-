using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HowManyTimesNumberAppearsInArray
{
    class NumberAppearsInArray
    {   
        static void CheckNumbers(int[] array, int checkNumber)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                if (temp == checkNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine("The number is appear {0} times.", counter);
        }
        static void Main()
        {
            Console.Write("Enter arrays lenght: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number you want to check: ");
            int checkNumber = int.Parse(Console.ReadLine());

            CheckNumbers(array, checkNumber);
        }
    }
}
