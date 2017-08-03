using System;


namespace _4.LectureHomework
{
    class PrintSum
    {
        static void Main()
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            int c = int.Parse(Console.ReadLine());
            int sum = (a + b + c);
            Console.WriteLine("The sum from a, b and c is: {0}", sum);
        }
    }
}
