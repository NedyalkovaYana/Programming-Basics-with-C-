using System;


namespace _3.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyName = "OBB AD";
            string address = "Sofia, Slaveikov";
            long phoneNumber = 0885657505;
            string webSite = "ubb.bg";
           
            string managerFirstName = "Yuri";
            string managerLastName = "Stoyanov";
            sbyte managerAge = 48;
            long managerPhoneNumber = 028378735;
            Console.WriteLine("Company name: {0}", companyName);
            Console.WriteLine("Company address is: {0}", address);
            Console.WriteLine("Company phone number: {0}", phoneNumber);
            Console.WriteLine("Company web site: {0}", webSite);
            Console.WriteLine("The company manager is: {0} {1}", managerFirstName, managerLastName);
            Console.WriteLine("Manager age is: {0}", managerAge);
            Console.WriteLine("Manager`s phone number is: {0}", managerPhoneNumber);


            

        }
    }
}
