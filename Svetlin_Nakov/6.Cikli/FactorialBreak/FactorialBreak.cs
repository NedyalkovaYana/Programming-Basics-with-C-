using System;


namespace FactorialBreak
{
    class FactorialBreak
    {
        static void Main()
        {
            Console.Write("n= ");
            string consoleInputLine = Console.ReadLine();
            int n = Convert.ToInt32(consoleInputLine);

            Console.Write("n! = ");
            decimal factorial = 1;

            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }
                Console.Write(" * ");
                factorial *= n;
                n--;
                Console.WriteLine(" ={0}", factorial);

            }





        }
    }
}
