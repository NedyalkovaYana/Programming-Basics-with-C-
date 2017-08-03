using System;


namespace _10.CalculateSumWithAccuracy
{
    class CalculateSumWithAccuracy
    {
        static void Main()
        {
            decimal sum = 0M;
            for (decimal i = 1M; i < 100; i++)
            {
                checked
                {
                    if ( i % 2 == 0)
                    {
                        sum = (1 / i) + sum;
                    }
                    else
                    {
                        sum = (1 / i) - sum;
                    }
                }
            }
            Console.WriteLine("The result of calculating the \"1+1/2-1/3+1/4-1/5+...+1/100\" is: {0:0.000}", sum);
        }
    }
}
