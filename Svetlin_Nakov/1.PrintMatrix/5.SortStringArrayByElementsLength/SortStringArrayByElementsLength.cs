using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortStringArrayByElementsLength
{
    class SortStringArrayByElementsLength
    {
        static void SortBySize(string[] array)
        {
            int[] sizes = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                sizes[i] = array[i].Length;

            }
            Array.Sort(sizes, array);
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

        }
        static void Main()
        {
            string[] stringArray = { "horse", "cat", "mouse", "frog", "dog" };
            SortBySize(stringArray);
        }
    }
}
