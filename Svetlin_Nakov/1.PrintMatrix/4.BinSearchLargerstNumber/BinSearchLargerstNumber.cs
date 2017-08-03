using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinSearchLargerstNumber
{
    class BinSearchLargerstNumber
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(array);
            int index = Array.BinarySearch(array, k);

            if (array[0] > k)
            {
                Console.WriteLine("There is no such number in the array.");
            }
            else
            {
                if (index >= 0)
                {
                    Console.WriteLine("The number is {0}", array[index]);
                }
                else
                {
                    Console.WriteLine("The number is {0}", array[-index - 2]);
                }
            }
        }
    }
}
