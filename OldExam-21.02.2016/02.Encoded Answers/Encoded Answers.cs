using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encoded_Answers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;
            

            for (int i = 1; i <= n; i++)
            {
                uint numberForAnswers = uint.Parse(Console.ReadLine());
                string answer;

                if (numberForAnswers % 4 == 0)
                {
                    answer = "a";
                    countA++;
                }
                else if (numberForAnswers % 4 == 1)
                {
                    answer = "b";
                    countB++;
                }
                else if (numberForAnswers % 4 == 2)
                {
                    answer = "c";
                    countC++;
                }
                else 
                {
                    answer = "d";
                    countD++;
                }

                result += answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine($"Answer A: {countA}\nAnswer B: {countB}\nAnswer C: {countC}\nAnswer D: {countD}");

        }
    }
}
