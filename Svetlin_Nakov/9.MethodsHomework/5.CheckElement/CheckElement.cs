﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CheckElement
{
    class CheckElement
    {
        static void CheckBiggerNumber(int[] array, int position)
        {
            if (array.Length == 1)
            {
                Console.WriteLine("The element has no neighbors");
            }
            else if (position == 0)
            {
                Console.WriteLine("The comparable numbers are {0} and {1}", array[position], array[position + 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(array[position], array[position + 1]));
            }
            else if (position == array.Length - 1)
            {
                Console.WriteLine("The comparable numbers are {0} and {1}", array[position], array[position - 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(array[position], array[position - 1]));
            }
            else if ((position > 0) && (position < array.Length - 1))
            {
                Console.WriteLine("The comparable numbers are {0}, {1} and {2}", array[position], array[position + 1], array[position - 1]);
                Console.WriteLine("The bigger number is: " + Math.Max(Math.Max(array[position], array[position + 1]), array[position - 1]));
            }
            else
            {
                Console.WriteLine("There is no such number in this position. Try again... ");

            }
        }


        static void Main()
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter array elements ...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Position [{0}] -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter element position you want to check: ");
            int position = int.Parse(Console.ReadLine());

            CheckBiggerNumber(array, position);
        }
    }
}

          
    

