using System;


namespace _01.Distance
{
    class Program
    {
        static void Main()
        {
            int initialSpeedKmh = int.Parse(Console.ReadLine());
            int firstTimeInMinutes = int.Parse(Console.ReadLine());
            int secondTimeInMinutes = int.Parse(Console.ReadLine());
            int thirdTimeInMinutes = int.Parse(Console.ReadLine());

            double distanceWhitFirstTime = initialSpeedKmh * (firstTimeInMinutes / 60.0);
            double increaseSpeed = initialSpeedKmh + (initialSpeedKmh * 0.1);
            double distanceWhitSecondTime = increaseSpeed * (secondTimeInMinutes / 60.0);
            double speedAfterDecrease = increaseSpeed - (increaseSpeed * 0.05);
            double distanceWhitThirdTime = speedAfterDecrease * (thirdTimeInMinutes / 60.0);

            double totalKmh = distanceWhitFirstTime + 
                              distanceWhitSecondTime + 
                              distanceWhitThirdTime;

            Console.WriteLine($"{totalKmh:f2}");

        }
    }
}
