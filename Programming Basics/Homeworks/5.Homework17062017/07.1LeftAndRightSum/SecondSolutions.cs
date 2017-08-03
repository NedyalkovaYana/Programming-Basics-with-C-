using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1LeftAndRightSum
{
    class SecondSolutions
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i<n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
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
