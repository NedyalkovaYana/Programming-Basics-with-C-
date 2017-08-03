using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            //Console.Write("Enter number of elements: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int index = 0; index < n; index++)
            //{
            //    Console.Write("Enter element {0}: ", index);
            //    arr[index] = int.Parse(Console.ReadLine());
            //}


            TestMergeSort();
           
        }

        private static void TestMergeSort()
        {
            int[] arr = { 8, 12, 46, 6, 1, 2, 18, 7, 4, 11, 10, };
            arr = DoMergeSort();
           
            foreach (var i in arr )
            {
                Console.WriteLine(" " + i);
            }

        }
    }
}
