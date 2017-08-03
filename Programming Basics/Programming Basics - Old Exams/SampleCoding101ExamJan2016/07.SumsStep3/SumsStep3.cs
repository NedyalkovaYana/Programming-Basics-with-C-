using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumsStep3
{
    class SumsStep3
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int count1 = 1;
            int count2 = 2;
            int count3 = 3;
            
            for (int i = 1; i <= number; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (i == count1)
                {
                    sum1 += nextNum;
                    count1 += 3;
                }
                else if (i == count2)
                {
                    sum2 += nextNum;
                    count2 += 3;
                }
                else if (i == count3)
                {
                    sum3 += nextNum;
                    count3 += 3;
                }
            }
            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
