using System;


namespace _3.CalcRectangleArea
{
    class CalcRectangleArea
    {
        static void Main()
        {
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }
}
