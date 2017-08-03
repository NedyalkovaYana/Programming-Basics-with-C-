using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            var sumSmaller = (sum - maxNumber);

            if ((sumSmaller) == maxNumber)
            {
                Console.WriteLine("Yes, sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(maxNumber - sumSmaller));
            }

        }
    }
}
