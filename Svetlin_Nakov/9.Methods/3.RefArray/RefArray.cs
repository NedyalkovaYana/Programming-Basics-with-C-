using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RefArray
{
    class RefArray
    { static void NewArray(ref int[] arr)
        {
            arr = new int[] { 11, 12, 13, 14, 15, 16 };

        }

        static void PrintArray(int[] arr)
        {
            foreach (var value in arr)
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] arr =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintArray(arr);
            NewArray(ref arr);
            PrintArray(arr);


        }
    }
}
