using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int minNumber = firstNumber;

            for (int i = 0; i < numbers - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
