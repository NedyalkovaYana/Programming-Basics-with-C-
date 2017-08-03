using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MethodParameter
{
    class MethodParameter
    { static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero", number);
            }
        }

        static void PrintMax(float number1, float number2)
        {

            float max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
            Console.WriteLine("Maximal number is: {0}", max);
        }
        static void Example(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + 1;
            }
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
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray(arr);
            Example(arr);
            PrintArray(arr);

            
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            PrintSign(n);
            PrintSign(m);
            PrintMax(n, m);


        }

       
    }
}
