using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SchoolCamp
{
    class SchoolCamp
    {
        static void Main()
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int sleepNights = int.Parse(Console.ReadLine());
            double nightPrice = 0;
            string sport = "";

            if (group == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        nightPrice = sleepNights * numberOfStudents * 9.60;
                        sport = "Gymnastics";
                        break;
                    case "Spring":
                        nightPrice = sleepNights * numberOfStudents * 7.20;
                        sport = "Athletics";
                        break;
                    case "Summer":
                        nightPrice = sleepNights * numberOfStudents * 15;
                        sport = "Volleyball";
                        break;
                }
            }
            else if (group == "boys")
            {
                switch (season)
                {
                    case "Winter":
                        nightPrice = sleepNights * numberOfStudents * 9.60;
                        sport = "Judo";
                        break;
                    case "Spring":
                        nightPrice = sleepNights * numberOfStudents * 7.20;
                        sport = "Tennis";
                        break;
                    case "Summer":
                        nightPrice = sleepNights * numberOfStudents * 15;
                        sport = "Football";
                        break;
                }
            }
            else if (group == "mixed")
            {
                switch (season)
                {
                    case "Winter":
                        nightPrice = sleepNights * numberOfStudents * 10;
                        sport = "Ski";
                        break;
                    case "Spring":
                        nightPrice = sleepNights * numberOfStudents * 9.50;
                        sport = "Cycling";
                        break;
                    case "Summer":
                        nightPrice = sleepNights * numberOfStudents * 20;
                        sport = "Swimming";
                        break;
                }
            }
            if (numberOfStudents >= 50)
            {
                nightPrice *= 0.5;
            }
            else if ((numberOfStudents >=20) && (numberOfStudents < 50))
            {
                nightPrice = nightPrice - ( nightPrice * 0.15);
            }
            else if ((numberOfStudents >= 10) && (numberOfStudents < 20))
            {
                nightPrice = nightPrice - (nightPrice * 0.05);
            }

            Console.WriteLine("{0} {1:F2} lv.", sport, nightPrice);
        }
    }
}

