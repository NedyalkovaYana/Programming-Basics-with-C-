using System;
using System.Numerics;


namespace _9.MembersOfFibonacci
{
    class MembersOfFibonacci
    {
        static void Main()
        {
            Console.WriteLine("The first 100 members of Fibonacci sequence: ");
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger neutralNum;

            Console.WriteLine(secondNum);
            for (int i = 0; i < 100; i++)
            {
                neutralNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = neutralNum;
                Console.WriteLine(neutralNum);
            }

        }

    }
}
