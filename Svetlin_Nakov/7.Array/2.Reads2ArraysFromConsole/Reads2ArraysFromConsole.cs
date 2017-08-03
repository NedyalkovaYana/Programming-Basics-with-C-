using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reads2ArraysFromConsole
{
    class Reads2ArraysFromConsole
    {
        static void Main()
        {
            Console.WriteLine("Enter integers for array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]", i);
                arr1[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Enter integers for next array:");
            int nextarr = int.Parse(Console.ReadLine());
            int[] arr2 = new int[nextarr];
            for (int i = 0; i < nextarr; i++)
            {
                Console.Write("arr[{0}]", i);
                arr2[i] = int.Parse(Console.ReadLine());

            }
            //Console.WriteLine(arr1.SequenceEqual(arr2)); 
            //Console.WriteLine(arr1.Reverse().SequenceEqual(arr2));
            foreach (var itemA in arr1)
            {
                foreach (var itemB in arr2)
                {
                    if (itemB == itemA)
                    {
                        true;
                    }
                }
            }
            false;

        }
        //public bool IsPresentInArray(int[] arr1, int[] arr2)
        //{
            
        //}
    }
}
