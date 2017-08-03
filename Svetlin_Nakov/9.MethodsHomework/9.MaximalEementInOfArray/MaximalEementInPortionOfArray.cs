using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MaximalEementInOfArray
{
    class MaximalEementInPortionOfArray
    {   
        static void SortArray(int[] array)
        {
            int number = 0;
            //Sorting an array in ascending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        number = array [j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }
            //Print array in ascending order
            Console.WriteLine("Sort array: ");
            Console.Write("In ascending order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

            //Sorting array in descending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }
            //Print array int descendin 
            Console.Write("In descending order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
        static void MaximalElementInArray(int[] array)
        {
            int maximalElement = array.Max();
            Console.Write("The maximal element in array is: {0} ", maximalElement);
        }
        static void MaximalElementInPortiontOfArray(int[] array, int firstIndex)
        {
            int  maximalElementInPortion = 0;
            for (int i = firstIndex; i < array.Length; i++)
            {
                if (array[i] > maximalElementInPortion)
                {
                    maximalElementInPortion = array[i];
                }
            }
            Console.Write("Max element in the portion of array is: {0} ", maximalElementInPortion);
        }
        static void Main()
        {
            Console.Write("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter array's element: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Index [{0}] ->",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter first index of the portion where you want to search: ");
            int firstIndex = int.Parse(Console.ReadLine());

            MaximalElementInArray(array);
            MaximalElementInPortiontOfArray(array, firstIndex);
            SortArray(array);
        }
    }
}
