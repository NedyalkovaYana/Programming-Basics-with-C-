using System;


namespace _7.StringObject
{
    class PStringObject
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";

            object objectGreeting = firstWord + " " + secondWord;
            Console.WriteLine(firstWord + " " + secondWord);
            string stringGreeting = objectGreeting.ToString();
            Console.ReadLine();

        }
    }
}
