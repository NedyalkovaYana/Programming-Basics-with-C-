using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EqualElementArrays
{
    class EqualElementArrays
    {
        static void Main()
        {
            string number;
            int nNum;
            int maxSeqSize = 1;
            int tempSeqSize = 1;
            int seqElemValue = 1;

            do
            {
                Console.WriteLine("Enter number of elements in the array:");
            } while (!int.TryParse(number = Console.ReadLine(), out nNum)|| nNum <=1 );
            int[] array = new int[nNum];
            for (int i = 0; i < nNum; i++)
            {
                Console.WriteLine("Enter element {0}", i);
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < (nNum - 1); i++)
            {
                if (array[i]==array[(i + 1)])
                {
                    tempSeqSize++;
                }
                else
                {
                    if (maxSeqSize < tempSeqSize)
                    {
                        maxSeqSize = tempSeqSize;
                        seqElemValue = array[i];
                    }
                    tempSeqSize = 1;
                }
            }
            for (int j = 0; j <= maxSeqSize; j++)
            {
                if (maxSeqSize>1)
                {
                    Console.WriteLine("{0}", seqElemValue);
                }
                else
                {
                    Console.WriteLine("Not repeat value founds");
                }
            }

        }
    }
}
