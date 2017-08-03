using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main()
        {
            int pokemoniGamerOne = int.Parse(Console.ReadLine());
            int pokemoniGamerTwo = int.Parse(Console.ReadLine());
            int maxNumberBattle = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= pokemoniGamerOne; i++)
            {
                for (int j = 1; j <= pokemoniGamerTwo; j++)
                {
                    count++;
                    if (count<= maxNumberBattle )
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }
                }
            }
        }
    }
}
