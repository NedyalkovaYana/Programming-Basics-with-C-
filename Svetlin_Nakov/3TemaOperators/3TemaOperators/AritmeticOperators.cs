using System;


namespace _3TemaOperators
{
    class AritmeticOperators
    {
        static void Main()
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);
            Console.WriteLine(Environment.NewLine);

            int a = 5;
            int b = 4;
            Console.WriteLine(a+b);
            Console.WriteLine(a+b++);
            Console.WriteLine(a+b);
            Console.WriteLine(a+(++b));
            Console.WriteLine(a+b);

            Console.WriteLine(11/3);
            Console.WriteLine(11%3);
            Console.WriteLine(12/3);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("1.5/0.0=" +(1.5/0.0));
            Console.WriteLine("0.0/0.0=" +(0.0/0.0));
            Console.WriteLine(Environment.NewLine);

            checked
            {
                int x = 2000000000;
                int y = 2000000000;
                long sum = x;
                sum = sum + y;
                Console.WriteLine(sum);
            }
        }
    }
}
