using System;


namespace Quotation
{
    class quotation
    {
        static void Main()
        {
            string quotedString = @"The ""use"" quotations causes difficulties";
            string unquotedString = "The \"use\" quotations causes difficulties";
            Console.WriteLine(quotedString);
            Console.WriteLine(unquotedString);

        }
    }
}
