using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string homeTown = Console.ReadLine();
            string currentTown = Console.ReadLine();

            //if (age >= 0)
            //{
            //    if (currentTown == homeTown)
            //    {
            //        Console.WriteLine("Vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cant vote");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Cant vote");
            //}

            //OR

            //if (age >=18 && homeTown == currentTown)
            //{
            //    Console.WriteLine("Can vote");
            //}
            //else
            //{
            //    Console.WriteLine("Cant vote");
            //}

            //OR

            bool hasAgeForVoting = age >= 18;
            bool isInHomeTime = homeTown == currentTown;
            if (hasAgeForVoting && isInHomeTime )
            {
                Console.WriteLine("Vote");
            }
            else
            {
                Console.WriteLine("cant vote");
            }
        }
    }
}
