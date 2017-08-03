using System;


namespace SwitchCase
{
    class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number between (1...7):");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Tursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
               default:
                    Console.WriteLine("Invalid number!");
                    break;



            }

        }
    }
}
