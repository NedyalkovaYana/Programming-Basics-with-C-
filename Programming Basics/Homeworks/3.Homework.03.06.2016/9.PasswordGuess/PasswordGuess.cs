using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string inputPass = Console.ReadLine();
            string expectedPassword = "s3cr3t!P@ssw0rd";

            if (inputPass == expectedPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
