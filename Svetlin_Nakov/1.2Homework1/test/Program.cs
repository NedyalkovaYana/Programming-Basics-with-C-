using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale;
            Console.WriteLine("Enter your gender - male or female:");
            string gender = Console.ReadLine(); 
            if (gender == "male")
            {
                isFemale = false; Console.WriteLine(isFemale + " " + "You are not female");
            }

            else
            {
                isFemale = true; Console.WriteLine(isFemale + " " + "You are female");
            }
        }
    }
}
