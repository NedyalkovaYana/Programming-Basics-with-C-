using System;

namespace _14.ChooseCorrectVariable
{
    class ChooseCorrectVariable
    {
        static void Main()
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            object IBAN;
            object BICcode;
            long creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;

            firstName = "Ivan";
            middleName = "Ivannov";
            lastName = "Popov";
            balance = 987.00M;
            bankName = "OBB AD";
            IBAN = "BG85STSA12345678912345";
            BICcode = "STSABGSF";
            creditCardNumber1= 6776030078884332;
            creditCardNumber2= 6776030078884332;
            creditCardNumber3= 6776030078884332;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", firstName,middleName,lastName,balance,bankName, IBAN,BICcode, creditCardNumber1, creditCardNumber2, creditCardNumber3);





        }
    }
}
