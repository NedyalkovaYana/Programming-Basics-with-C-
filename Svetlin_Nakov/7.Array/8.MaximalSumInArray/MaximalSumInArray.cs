using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MaximalSumInArray
{
    class MaximalSumInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < n; index++)
            {
                Console.WriteLine("Enter arrays element {0}", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            int maxTemp = int.MinValue;
            int maxEnd = 0;
            int start = 0;
            int startTemp = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxEnd += arr[i];
                if (arr[i] > maxEnd)
                {
                    maxEnd = arr[i];
                    startTemp = i;

                }
                if (maxEnd > maxTemp)
                {
                    maxTemp = maxEnd;
                    start = startTemp;
                    end = i;
                }
            }
            Console.WriteLine("The sequence with maximal sum is: {0}", maxTemp);
            for (int j = start; j < end; j++)
            {
                Console.Write(arr[j]+ " ");
            }

        }
    }
}
