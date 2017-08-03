using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var leftSum = 0;
            for (var i = 0; i < numbers; i++)
            {
                leftSum += int.Parse(Console.ReadLine());

            }
            var rightSum = 0;
            for (var i = 0; i < numbers; i++)
            {
                rightSum += int.Parse(Console.ReadLine());

            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else 
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", difference);
            }

        }
    }
}
