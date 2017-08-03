using System;


namespace _4.MathClass
{
    class MathClass
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a real number for \"x\":");
            long x = long.Parse(Console.ReadLine());
           
            double formula1 = (Math.Sin(x) / x) + Math.Pow(10, x);
            Console.WriteLine("The result of the Formula 1, x = {0}", formula1);

            double formula2 = (Math.Pow(x, 10)/2*x)-(Math.Abs(x)/2);
            Console.WriteLine("The result of the Formula 2, x = {0}", formula2);

            double formula3 = 2 * (Math.Pow(10, Math.Abs(x)) / (x + (5 ^ 2)));
            Console.WriteLine("The result of the Formula 3, x = {0}", formula3);

            double formula4 = x + ((Math.Pow(10, (2 * x)) / Math.Cos(x)) + (Math.Abs(100 - (x ^ 2))));
            Console.WriteLine("The result of the Formula 4, x = {0}", formula4);

            double formula5 = Math.Pow(-(2 * x + x), (double)(1 / 3));
            Console.WriteLine("The result of the Formula 5, x = {0}", formula5);

            double formula6 = ((5 * x * Math.Sqrt(100)) + ((x / 2) * x));
            Console.WriteLine("The result of the Formula 6, x = {0}", formula6);
            }
           

        }
    }

