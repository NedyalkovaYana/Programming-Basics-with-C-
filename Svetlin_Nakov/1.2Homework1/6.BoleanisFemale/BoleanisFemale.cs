using System;


namespace _6.BoleanisFemale
{
    class BoleanisFemale
    {
        static void Main()
        {
            bool isFemale = true;
           
            Console.WriteLine("What is your gender (type \"male\" or \"female\"): ");
            string myGender = Console.ReadLine();

            if (myGender == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
            Console.WriteLine("Are you female: " + isFemale);

        }
    }
}
