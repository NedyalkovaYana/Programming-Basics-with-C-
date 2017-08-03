using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {

            var inputNumber = int.Parse(Console.ReadLine());
            var getFirstDigit = (inputNumber / 100) % 10;
            var getSecondDigit = (inputNumber / 10) % 10;
            var getThirdDigit = inputNumber % 10;
            var n = getFirstDigit + getSecondDigit;
            var m = getFirstDigit + getThirdDigit;
            var newNumber = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (inputNumber % 5 == 0)
                    {
                      inputNumber -= getFirstDigit;
                    }
                    else if (inputNumber % 3 == 0)
                    {
                       inputNumber -= getSecondDigit;
                    }
                    else
                    {
                        inputNumber += getThirdDigit;
                    }

                   Console.Write("{0}", inputNumber);
                    if (j<m)
                    {

                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
