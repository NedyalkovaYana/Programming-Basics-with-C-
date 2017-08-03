using System;


namespace _01
{
    class Program
    {
        static void Main()
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double total = whiskeyPrice * whiskeyQuantity +
                           beerPrice * beerQuantity +
                           winePrice * wineQuantity +
                           rakiaPrice * rakiaQuantity;
            Console.WriteLine($"{total:f2}");
        }
    }
}
