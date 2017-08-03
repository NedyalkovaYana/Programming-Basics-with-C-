using System;


namespace _8.FindTrapezoidArea
{
    class FindTrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Please write trapezoid's \"a\" base:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write trapezoid's \"b\" base:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write trapezoid's \"h\" base:");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of your trapezoid is: {0}", area);

        }
    }
}
