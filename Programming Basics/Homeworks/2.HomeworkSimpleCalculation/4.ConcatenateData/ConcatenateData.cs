﻿using System;

namespace _4.ConcatenateData
{
    class ConcatenateData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);

        }
    }
}
