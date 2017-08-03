using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualWords
{
    class EqualWords
    {
        static void Main()
        {
            string word = (Console.ReadLine().ToLower());
            string anotherWord = (Console.ReadLine().ToLower());

            if (word == anotherWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
