using System;


namespace Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the length of the side: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the side: ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            Console.WriteLine("The area of rectangle is: {0}", area);
            Console.WriteLine();
        }
    }
}
