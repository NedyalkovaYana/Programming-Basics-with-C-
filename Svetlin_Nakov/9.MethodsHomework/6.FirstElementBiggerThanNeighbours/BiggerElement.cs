using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FirstElementBiggerThanNeighbours
{
    class BiggerElement
    {    
        static void CheckElements(int[]array)
        {
            int firstBigIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                int firstBig = array[index];
                if ((firstBig > array[index + 1]) &&(firstBig > array[index - 1]))
                {
                    firstBigIndex = index;
                    break;
                }
                else
	            {
                    firstBigIndex = -1;
                }
                Console.Write("The index is: {0}", firstBigIndex);
            }
        }
        static void Main()
        {
            Console.Write("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array element: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            CheckElements(array);
            Console.WriteLine();
        }
    }
}
