using System;


namespace _6.Cikli
{
    class PrimeOrNot
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            string consoleArgument = Console.ReadLine();
            uint number = uint.Parse(consoleArgument);
            if (number < 2)
            {
                Console.WriteLine("Not prime!");
                return;
            }

            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider ==0)
                {
                    prime = false;
                    Console.WriteLine("Found divider: {0}*{1}={2}", divider, number/divider, number);

                }
                divider++;


            }
            Console.WriteLine("Prime? {0}", prime);



            }
        }

        }
    

