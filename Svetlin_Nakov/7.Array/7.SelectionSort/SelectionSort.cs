using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int index = 0; index < n; index++)
            {
                Console.WriteLine("Enter element {0}:", index);
                array[index] = int.Parse(Console.ReadLine());
            }
            int minKeyElement = 0;
            int tmpElement = int.MinValue;

            for (int j = 0; j < array.Length - 1; j++)
            {
                minKeyElement = j;

                for (int p = j + 1; p < array.Length; p++)
                {
                    if (array[p] < array[minKeyElement])
                    {
                        minKeyElement = p;
                    }
                }

                tmpElement = array[minKeyElement];
                array[minKeyElement] = array[j];
                array[j] = tmpElement;
            }

            // Sorted array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
