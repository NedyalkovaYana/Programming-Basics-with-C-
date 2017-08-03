using System;


namespace _8.TriangleArea
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a * h / 2);

            Console.WriteLine("Area = {0}", Math.Round(area, 2));
        }
    }
}
