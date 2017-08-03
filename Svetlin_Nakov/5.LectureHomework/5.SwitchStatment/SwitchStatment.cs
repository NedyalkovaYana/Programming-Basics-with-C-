using System;


namespace _5.SwitchStatment
{
    class SwitchStatment
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number between (1 and 10): ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("You enter number ONE!");
                    break;
                case 2: Console.WriteLine("You enter number TWO!");
                    break;
                case 3: Console.WriteLine("You enter number THREE!");
                    break;
                case 4: Console.WriteLine("You enter number FOUR!");
                    break;
                case 5: Console.WriteLine("You enter number FIVE!");
                    break;
                case 6: Console.WriteLine("You enter number SIX!");
                    break;
                case 7: Console.WriteLine("You enter number SEVEN!");
                    break;
                case 8: Console.WriteLine("You enter number EIGHT!");
                    break;
                case 9: Console.WriteLine("You enter number NINE!");
                    break;
                case 10: Console.WriteLine("You enter number TEN!");
                    break;
                default:
                    Console.WriteLine("NOT A VALID ENTRY!!!!!!!");
                    break;
            }
        }
    }
}


