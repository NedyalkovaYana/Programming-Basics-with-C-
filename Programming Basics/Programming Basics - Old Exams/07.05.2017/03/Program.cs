using System;


namespace _03
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            string studentsType = Console.ReadLine().ToLower();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightsPrice = 0.0;
           
            string sport = String.Empty;

            switch (season)
            {
                case "winter":
                    {
                        switch (studentsType)
                        {
                            case "boys":   nightsPrice = 9.6;    sport = "Judo";        break;
                            case "girls":  nightsPrice = 9.6;    sport = "Gymnastics";  break;
                            case "mixed":  nightsPrice = 10.0;   sport = "Ski";         break;
                        }
                        break;
                    }
                case "spring":
                    {
                        switch (studentsType)
                        {
                            case "boys":   nightsPrice = 7.2;   sport = "Tennis";     break;
                            case "girls":  nightsPrice = 7.2;   sport = "Athletics";  break;
                            case "mixed":  nightsPrice = 9.5;   sport = "Cycling";    break;
                        }
                        break;
                    }
                   
                case "summer":
                    {
                        switch (studentsType)
                        {
                            case "boys":   nightsPrice = 15.0;   sport = "Football";     break;
                            case "girls":  nightsPrice = 15.0;   sport = "Volleyball";  break;
                            case "mixed":  nightsPrice = 20.0;   sport = "Swimming";    break;
                        }
                        break;
                    }
            }
            double total = nightsPrice * studentsCount * nights;

            if (studentsCount >= 50)
            {
                total /= 2;
            }
            else if (studentsCount >= 20)
            {
                total -= total * 0.15;
            }
            else if (studentsCount >= 10)
            {
                total -= total * 0.05;
            }

            Console.WriteLine($"{sport} {total:f2} lv.");
        }
    }
}
