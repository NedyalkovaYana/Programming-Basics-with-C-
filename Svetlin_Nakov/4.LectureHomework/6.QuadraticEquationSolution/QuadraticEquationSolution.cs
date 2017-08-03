using System;


namespace _6.QuadraticEquationSolution
{
    class QuadraticEquationSolution
    {
        static void Main()
        {
            double a, b, c;
            double discriminant;
            double x1, x2;  
            Console.WriteLine("Please enter the coefficient a:");
            bool isaInt = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please enter the coefficient b:");
            bool isbInt = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Please enter the coefficient c:");
            bool iscInt = double.TryParse(Console.ReadLine(), out c);

            //ax2+bx+c=0

            if (isaInt & isbInt & iscInt)
            {
                discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;

                    x2 = (b + Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("There are not real roots!");
                }

            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
            }
        }
    }
}
