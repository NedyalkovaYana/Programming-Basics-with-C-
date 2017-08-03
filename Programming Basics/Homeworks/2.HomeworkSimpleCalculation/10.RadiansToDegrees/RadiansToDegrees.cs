using System;


namespace _10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main()
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine("{0}", Math.Round(deg,0));
        }
    }
}
