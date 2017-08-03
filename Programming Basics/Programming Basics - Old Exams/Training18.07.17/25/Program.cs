using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemoniFirstPlayer = int.Parse(Console.ReadLine());
            int pokemoniSecondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= pokemoniFirstPlayer; i++)
            {
                for (int j = 1; j <= pokemoniSecondPlayer; j++)
                {
                    count++;
                    if (count <= maxBattles)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }


                }
            }
        }
    }
}
