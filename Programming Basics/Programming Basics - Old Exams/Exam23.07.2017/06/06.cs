using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            char BigLetter = char.Parse(Console.ReadLine());
            char littleLetterOne = char.Parse(Console.ReadLine());
            char littleLetterTwo = char.Parse(Console.ReadLine());
            char littleLetterThree = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for (char i = 'A'; i <= BigLetter; i++)
            {
                for (char j = 'a'; j <=littleLetterOne; j++)
                {
                    for (char a = 'a'; a <=littleLetterTwo; a++)
                    {
                        for (char b = 'a'; b <=littleLetterThree; b++)
                        {
                            for (int c = 0; c <= number; c++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count - 1);
        }
    }
}
