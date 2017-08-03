using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int maxNumber = firstNumber;

            for (int i = 0; i < numbers - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
          
        }
    }
}
