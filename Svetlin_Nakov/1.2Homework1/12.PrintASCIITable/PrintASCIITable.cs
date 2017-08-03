using System;
using System.Text;

namespace _12.PrintASCIITable
{
    class PrintASCIITable
    {
        public static Encoding EncodingUnicode { get; private set; }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            char symbol;

            for (int i = 0; i <= 255; i++)
            {
                symbol = (char)i;
                Console.WriteLine("{0} -> {1}", i, symbol);
            }


        }


            }
        }
    
