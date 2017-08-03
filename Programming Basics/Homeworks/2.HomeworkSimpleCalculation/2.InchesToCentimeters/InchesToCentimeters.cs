using System;


namespace _2.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main()
        {
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine("Centimeters = {0}", centimeters);
        }
    }
}
