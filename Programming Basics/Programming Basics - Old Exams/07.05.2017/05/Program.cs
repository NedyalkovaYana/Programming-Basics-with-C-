using System;

namespace _05
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int wight = (2 * n) - 1;
            int hight = (n / 2) + 4;

            Console.WriteLine("@{0}@{0}@",
                             new string(' ', n - 2));

            int blanckSpace = (wight - 5) / 2;
            int leftRightDots = 1;
            int middleDots = 1;


            for (int i = 1; i <= hight - 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("**{0}*{0}**",
                        new string(' ', blanckSpace));
                    blanckSpace -= 2;
                }
                else if (i == n / 2)
                {
                    //Console.WriteLine("*{0}*{1}*{0}*",
                    //      new string('.', leftRightDots),
                    //      new string('.', middleDots));
                    //leftRightDots++;
                    //middleDots += 2;

                    Console.WriteLine("*{0}{1}.{1}{0}*",
                        new string('.', leftRightDots),
                        new string('*', (n / 2) - 2));
                    break;

                }
                if (blanckSpace <= 0)
                {
                        Console.WriteLine("*{0}*{1}*{0}*",
                        new string('.', leftRightDots),
                        new string('.', middleDots));
                        leftRightDots++;
                        middleDots += 2;

                }
                    else
                    {
                        Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                     new string('.', leftRightDots),
                     new string(' ', blanckSpace),
                     new string('.', middleDots));
                        leftRightDots++;
                        blanckSpace -= 2;
                        middleDots += 2;
                    }
                
            }
            Console.WriteLine(new string('*', wight));
            Console.WriteLine(new string('*', wight));
        }

    }   
            
}



