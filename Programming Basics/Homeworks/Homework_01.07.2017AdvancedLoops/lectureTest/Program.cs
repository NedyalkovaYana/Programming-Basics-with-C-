using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectureTest
{
    class Program
    { 
        static void Main()
        {
            string word = Console.ReadLine();
            bool mentorNotFound = word != "mentor";
            bool hasWord = word != null;
            while (mentorNotFound && hasWord)
            {
                word = Console.ReadLine();
                if (word == "mentor")
                {
                    Console.WriteLine("Vdigam ruka!");
                    mentorNotFound = false;
                }
                
            }

        }
    }
}
