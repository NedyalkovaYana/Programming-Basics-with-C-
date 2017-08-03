using System;


namespace _10.AppropriateDataTypes
{
    class AppropriateDataTypes
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char gender;
            long IDnumber;
            uint uniqueEmployeeNumber;

             firstName = "Petar";
             familyName = "Nedyalkov";
             age = 35;
            gender = 'm';
            IDnumber = 8112312891;
            uniqueEmployeeNumber = 27560000;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", firstName, familyName, age, gender,IDnumber, uniqueEmployeeNumber);

        }
    }
}
