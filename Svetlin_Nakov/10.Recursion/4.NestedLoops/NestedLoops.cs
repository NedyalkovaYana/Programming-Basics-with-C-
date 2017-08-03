using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NestedLoops
{
    class NestedLoops
    {
       static int n = 3;
       static char[] word = new char[n];
        static bool Next()
        {
            int index = n - 1;
            while (index >= 0)
            {
                word[index]++;
                if (word[index] > 'c')
                {
                    word[index] = 'a';
                    index--;
                }
                else
                {
                    return true;
                }
            }
            if (index==-1)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            word = new char[] { 'a', 'a', 'a' };
            Print();
            while (Next())
            {
                Print();
            }
        }

        private static void Print()
        {
            foreach (var ch in word)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine();
        }
    }
}
