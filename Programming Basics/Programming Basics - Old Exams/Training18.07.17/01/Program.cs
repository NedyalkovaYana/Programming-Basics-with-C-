using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string seazon = Console.ReadLine();
            string gender = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            decimal price = 0;

            if (seazon == "Spring" && (gender == "girls" || gender == "boys"))//тук трябва да се сложат скоби иначе се изпълнява друго условие, а не това, което искаме
                price = nights * 7.2m;
            if (seazon == "Winter" && (gender == "girls" || gender == "boys"))//тук също
                price = nights * 9.6m;
            if (seazon == "Summer" && (gender == "girls" || gender == "boys"))//тук също
                price = nights * 15m;
            if (seazon == "Summer" && gender == "mixed")
                price = nights * 20m;
            if (seazon == "Winter" && gender == "mixed")
                price = nights * 10m;
            if (seazon == "Spring" && gender == "mixed")
                price = nights * 9.5m;

            decimal studentPrice = numStudents * price;

            if (numStudents >= 50) studentPrice = studentPrice - (studentPrice * 0.5m);
            if (numStudents >= 20 && numStudents < 50) studentPrice = studentPrice - (studentPrice * 0.15m);
            if (numStudents >= 10 && numStudents < 20) studentPrice = studentPrice - (studentPrice * 0.05m);

            if (gender == "girls" && seazon == "Winter")
                Console.Write("Gymnastics ");
            if (gender == "girls" && seazon == "Spring")
                Console.Write("Athletics ");
            if (gender == "girls" && seazon == "Summer")
                Console.Write("Volleyball ");
            if (gender == "boys" && seazon == "Winter")
                Console.Write("Judo ");
            if (gender == "boys" && seazon == "Spring")
                Console.Write("Tennis ");
            if (gender == "boys" && seazon == "Summer")
                Console.Write("Football ");
            if (gender == "mixed" && seazon == "Winter")
                Console.Write("Ski ");
            if (gender == "mixed" && seazon == "Spring")
                Console.Write("Cycling ");
            if (gender == "mixed" && seazon == "Summer")
                Console.Write("Swimming ");
            Console.WriteLine("{0:f2} lv.", studentPrice);
        }

    }
}