using System;


namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine("{0}", quantity * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine("{0}", quantity * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine("{0}", quantity * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine("{0}", quantity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine("{0}", quantity * 1.60);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine("{0}", quantity * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine("{0}", quantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine("{0}", quantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine("{0}", quantity * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine("{0}", quantity * 1.50);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine("{0}", quantity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine("{0}", quantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine("{0}", quantity * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine("{0}", quantity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine("{0}", quantity * 1.55);
                }
            }

        }
    }
}
