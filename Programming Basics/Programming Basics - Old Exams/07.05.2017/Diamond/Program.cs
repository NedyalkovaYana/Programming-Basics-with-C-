using System;


namespace Diamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftRightDash;
            int middleDash = 0;
            if (n % 2 == 0)
            {
                leftRightDash = (n - 2) / 2;
                for (int i = 1; i <= n/2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', leftRightDash),
                        new string('-', middleDash));
                    leftRightDash--;
                    middleDash += 2;
                }
                leftRightDash = 1;
                middleDash = n - 4;
                for (int i = 0; i < (n/2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', leftRightDash),
                        new string('-', middleDash));
                    leftRightDash++;
                    middleDash -= 2;
                }
            }
            else
            {
                leftRightDash = (n - 1) / 2;
                middleDash = 1;
                for (int i = 1; i <= (n/2)+1; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("{0}*{0}",
                       new string('-', leftRightDash));
                        leftRightDash--;
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                        new string('-', leftRightDash),
                        new string('-', middleDash));
                        leftRightDash--;
                        middleDash += 2;

                    }
                    
                }
                leftRightDash = 1;
                middleDash = n - 4;

                for (int i = 1; i <= n/2; i++)
                {
                    if (middleDash <=0)
                    {
                        Console.WriteLine("{0}*{0}",
                       new string('-', leftRightDash));
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                        new string('-', leftRightDash),
                        new string('-', middleDash));
                        leftRightDash++;
                        middleDash -= 2;
                    }
                    
                }
            }
        }
    }
}
