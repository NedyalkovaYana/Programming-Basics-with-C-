using System;


namespace _9.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            Console.Write("Celsius = ");
            double celsius = double.Parse(Console.ReadLine());
            double faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F): {0}", Math.Round(faren, 2));

        }
    }
}
