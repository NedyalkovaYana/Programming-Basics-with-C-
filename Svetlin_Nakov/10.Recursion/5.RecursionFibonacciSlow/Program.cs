using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RecursionFibonacciSlow
{
    class Program
    {
        //Primer kak ne se polzva rekursiya!!!!!!!!!!
        const int MAX_FIBONACCI_SEQUENCE_MEMBER = 1000;
        static decimal[] fib = new decimal[MAX_FIBONACCI_SEQUENCE_MEMBER];
        static decimal recoursiveCallsCounter = 0;
       
        static decimal Fibonacci(int n)
        {
            recoursiveCallsCounter++;
            if (fib[n] == 0)
            {
                if ((n == 1) || (n == 2))
                {
                    fib[n] = 1;
                }

                else
                {
                    fib[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            } 
            return fib[n];
        }
        static void Main()
        {
            int num = 20;
            decimal fib = Fibonacci(num);
            Console.WriteLine("Fib({0}) = {1}", num, fib);
            Console.WriteLine("Recursive calls = {0}", recoursiveCallsCounter);

        }
    }
}
