using System;

namespace _2.CalcAreaAndPerimeter
{
    class CalcAreaAndPerimeter
    {
        static void Main()
        {
            Console.WriteLine("Please enter the radius of a circle r: ");
            int r = int.Parse(Console.ReadLine());
            double perimeter = (2 * 3.14 * r);
            Console.WriteLine("The Perimeter of circle is: {0}", perimeter);
            double area = (3.14 * (r*r));
            Console.WriteLine("The Area of a circle is: {0}", area);




        }
    }
}
