using System;


namespace _3.TheBiggestNumberOfThreeInt
{
    class TheBiggestNumberOfThreeInt
    {
        static void Main()
        {
            Console.WriteLine("Please enter a three numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", c);

                }
            }
            else
            {
                if (b > a)
                {
                    if (b > c)
                    {
                        Console.WriteLine("The biggest number is: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: {0}", c);
                    }
                }    
            }
        }
    }
}
