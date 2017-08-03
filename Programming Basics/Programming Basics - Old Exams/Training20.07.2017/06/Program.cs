using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int getFirstDigit = (n / 100) %10;
            int getSecondDigit = (n / 10) % 10;
            int getThirdDigit = n % 10;
            int a = getFirstDigit + getSecondDigit;
            int b = getFirstDigit + getThirdDigit;
            int newNumber = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (n % 5 ==0)
                    {
                        n -= getFirstDigit;
                    }
                    else if (n % 3 ==0)
                    {
                        n -= getSecondDigit;
                    }
                    else
                    {
                        n += getThirdDigit;
                    }

                    Console.Write($"{n} ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
