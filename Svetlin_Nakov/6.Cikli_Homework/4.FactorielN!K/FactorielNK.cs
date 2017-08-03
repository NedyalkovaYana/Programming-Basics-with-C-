using System;
using System.Numerics;

namespace _4.FactorielN_K
{
    class FactorielNK
    {
        static void Main()
        {
            Console.Write("Enter value for N:");
            double N = double.Parse(Console.ReadLine());
            Console.Write("Enter value for K:");
            double K = double.Parse(Console.ReadLine());
            var factorialN = 0;
            var factorialK = 0;

            if (K < 1 || K < N || N < 1 )
            {
                Console.WriteLine("Invalid input!");
                return;
            }
           
            
            for (double i = 1; i <= N; i++)
            {

                factorialN = N * i;
               
                
            }
            for (double i = 1; i <= K; i++)
            {
                factorialK = K * i;
                
            }
            Console.WriteLine("{0}", factorialN / factorialK);


        }

     
    }
}



