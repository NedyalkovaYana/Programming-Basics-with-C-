using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.lexicographyclly
{
    class InputListTfromConsole
    {
        static void Main()
        {
            Console.WriteLine("Write the first string(char) array's elements, separated by \",\"");
            string first = Console.ReadLine();
            string[] tokens = first.Split(',');
            List<int> nums = new List<int>();
            int oneNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }
            foreach (object o in tokens)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Write the second string(char) array's elements, separated by \",\"");
            string second = Console.ReadLine();
            string[] tokens2 = second.Split(',');
            List<int> nums2 = new List<int>();
            int secondnum;
            foreach (string item in tokens2)
            {
                if (Int32.TryParse(item, out secondnum))
                    nums2.Add(secondnum);
            }
            foreach  (object o in tokens2)
            {
                Console.WriteLine(o);
            }





        }
    }
}
