using System;


namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m =");
            int m = int.Parse(Console.ReadLine());

            if ((n>1)&&(m>n))
            {

                for (int num = n; num <= m; num++)
                {
                    bool prime = true;
                    int divider = 2;
                    double maxDivider = Math.Sqrt(num);
                    while (divider <= maxDivider)
                    {
                        if (num % divider == 0)
                        {
                            prime = false;
                            break;
                        }
                        divider++;
                    }
                    if (prime)
                    {
                        Console.Write("{0} ", num);
                    }
                }
                    Console.WriteLine();
                }
                else
	            {
                Console.WriteLine("Invalid range!");
                }
            }
        }
    }

