using System;

namespace SquareArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine("Square area is: {0}", area);
        }
    }
}
