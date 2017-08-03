using System;


namespace _5.IntegerVariables
{
    class IntegerVariables
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a value for a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a value for b:");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = {0}\nb = {1}", a, b);
        }
    }
}
