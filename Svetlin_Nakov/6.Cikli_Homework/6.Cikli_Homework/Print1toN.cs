using System;


namespace _6.Cikli_Homework
{
    class Print1toN
    {
        static void Main()
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int a = 1;

            while (a<=n)
            {
                Console.WriteLine("{0}",a);
                a++;
            }
        }
    }
}
