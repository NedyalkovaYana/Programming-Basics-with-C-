using System;

namespace HomeworkLecture3
{
    class SumNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number for n:");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for m:");
            int numberM = int.Parse(Console.ReadLine());
            int sum=numberN;
            Console.Write("The sum {0} ", numberN);
            while (numberN < numberM)
            {
                numberN++;
                sum += numberN;
                Console.Write(" + " + numberN);
            }
            Console.WriteLine(" = " + sum);
        }
       
    }
}
