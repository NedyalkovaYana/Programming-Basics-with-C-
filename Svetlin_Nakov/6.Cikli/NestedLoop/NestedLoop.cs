using System;


namespace NestedLoop
{
    class NestedLoop
    {
        static void Main()
        {
            Console.Write("n = ");
            string consoleInput = Console.ReadLine();
            int n = int.Parse(consoleInput);
            Console.WriteLine();

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', (n-row)));
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("{0,-2}", column);
                }
                Console.WriteLine();
            }
        }
    }
}
