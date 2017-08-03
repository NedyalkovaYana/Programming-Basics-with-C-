using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Arrays
{
    class PrintArray5To100
    {
        static void Main()
        {
            var arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 1) * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
