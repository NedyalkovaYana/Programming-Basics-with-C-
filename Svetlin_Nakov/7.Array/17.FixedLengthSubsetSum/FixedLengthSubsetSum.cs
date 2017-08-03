using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.FixedLengthSubsetSum
{
    class FixedLengthSubsetSum
    {
        static int wantedSum;
        static int numberOfAddends;
        static bool solution = false;

        static void GenerateSubset(int[] array, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                Checksubsets(subset, elementsInSubset);
                return;
            }
            for (int i = current; i < array.Length; i++)
            {
                subset[index] = array[i];
                GenerateSubset(array, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void Checksubsets(int[] subset, int elementsInSubset)
        {
            if (elementsInSubset != numberOfAddends )
            {
                return;
            }
            int sum = 0;
            for (int i = 0; i < elementsInSubset; i++)
            {
                sum += subset[i];
            }
            if (sum == wantedSum )
            {
                for (int i = 0; i < elementsInSubset; i++)
                {
                    Console.Write("{0} ", subset[i]);
                }
                Console.WriteLine();
                solution = true;
            }
        }
            
           
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < n; index++)
            {
                Console.WriteLine("Enter element {0}: ", index);
                array[index] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter sum: ");
            wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter number of elements in the sum: ");
            numberOfAddends = int.Parse(Console.ReadLine());

            int[] subset = new int[n];

            for (int elementsInSubset = 1; elementsInSubset <= n; elementsInSubset++)
            {
                GenerateSubset(subset, array, 0, 0, elementsInSubset);

            }
            if (!solution)
            {
                Console.WriteLine("Ain't no subset of {0} elements with sum {1}.", numberOfAddends, wantedSum);
            }

        }
    }
}
