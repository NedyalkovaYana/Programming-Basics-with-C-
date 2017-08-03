using System;


namespace _2.Pow_N_M_
{
    class Program
    {
        static void Main()
        {
            double result = 0;
            Console.Write("Please, enter a number for x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter a number for y:");
            double y = double.Parse(Console.ReadLine());
            
            result = Math.Pow(x, y);

            Console.WriteLine("The result {0}^{1} is = {2}", x, y, result);

                
                
            
        }
    }
}
