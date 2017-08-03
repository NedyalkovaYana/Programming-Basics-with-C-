using System;


namespace _11.USDtoBGN
{
    class USDtoBGN
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double convector = 1.79549;
            double bg = usd * convector;
            Console.WriteLine("{0}", Math.Round(bg, 2));
        }
    }
}
