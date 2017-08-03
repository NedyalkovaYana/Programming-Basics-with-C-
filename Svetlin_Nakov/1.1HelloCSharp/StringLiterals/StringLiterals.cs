using System;


namespace StringLiterals
{
    class StringLiterals
    {
        static void Main()
        {
            string quotation = "\"Hello, Judi\", he said.";
            string path = "C:\\WINNT\\Darts.exe";
            Console.WriteLine(quotation);
            Console.WriteLine(path);

            quotation = @"""Hello, Jimmy!"", she answered.";
            path = @"C:\WINNT\Darts\Darts.exe";
            Console.WriteLine(quotation);
            Console.WriteLine(path);
        }
    }
}
