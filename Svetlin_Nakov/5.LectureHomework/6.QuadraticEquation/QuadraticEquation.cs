using System;


namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a, b, c, discriminant, x1, x2;
            Console.WriteLine("Please enter coefficient a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coefficient b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coefficient c:");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("This isnt Quadratic equation!!");
            }
            else
            {
                discriminant = ((b * b) - ((4 * a) * c));
                if (discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine("Root x1 = {0}", x1);
                    Console.WriteLine("Root x2 = {0}", x2);
                }

                else
                {
                    if (discriminant == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("Discriminant = 0 and root x1 is equal to x2: {0}", x1);
                    }
                    else
                    {
                        if (discriminant < 0)
                        {
                            Console.WriteLine("Quadratic equation hasn't got real roots because discriminant is: {0}", discriminant);
                        }
                    }
                }
            }
        }
    }
}
