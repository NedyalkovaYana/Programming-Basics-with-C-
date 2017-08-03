using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MathMethod
{
    class MathMethod
    {
        static void Main()
        {
            //int NumberOfVars = 50;
            //double numbers = new int[NumberOfVars];
            //double maxValue = double.MinValue;
            //double minValue = double.MaxValue;

            //int? min = numbers.Min();
            //int? max = numbers.Max();

            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            int numbers;
            Console.Write("Please, enter a number for N:");
            double numberN = double.Parse(Console.ReadLine());
            

            for (int index = 0; index < numberN; index++)
            {
                Console.Write("Enter {0} diferent numbers:", numberN);
                numbers = int.Parse(Console.ReadLine());
                int[] arr = new int[numbers];

                foreach (double element in arr)
                {
                    if (maxValue < element)
                        maxValue = element;
                    if (minValue > element)
                        minValue = element;
                }
                Console.WriteLine("The minimum value element is {0}", minValue);
                Console.WriteLine("The maximum value element is {0}", maxValue);
                Console.ReadKey(true);
            }







            //int maxValue = numbers[0];
            //for (int index = 0; index < NumberOfVars; index++)
            //{
            //    if (maxValue < numbers[index])
            //    {
            //        maxValue = numbers[index];
            //    }

            //}
            //Console.WriteLine("Max value is: " + maxValue);
            //Console.ReadLine();


            //int minValue = numbers[0];

            //for (int i = 0; i < NumberOfVars; i++)
            //{
            //    int number = numbers[i];

            //    if (number < minValue)
            //    {
            //        minValue = number;
            //    }
            //}
            //Console.WriteLine("Min is: {0}", minValue);
            //double average = numbers.Average();
            //Console.WriteLine("The average is: {0}", average);
        }

        }
    }

   

