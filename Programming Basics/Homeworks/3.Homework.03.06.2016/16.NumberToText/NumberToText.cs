using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string posDec = "";
            string posOne = "";
            string posTeen = "";
            string numWord = "";

            if (number >= 0 && number < 100)
            {
                // Number BETWEEN 0 and 99 [0..99]
                var digitDEC = number / 10;
                var digitONE = number % 10;
            }
    }
}
