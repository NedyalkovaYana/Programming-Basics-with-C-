using System;


namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
           
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(new string('*',n));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine('*' + new string(' ', n - 2) + '*');
            }
            Console.WriteLine(new string('*', n));
            Console.WriteLine();
        }
    }
}
