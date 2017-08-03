using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SortingBeers
{   class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
    }
        
    class Beers
    {
        static void Main(string[] args)
        {
            string[] beers = { "Zagorka", "Ariana", "Shumensko", "Astika", "Kamenica", "Bolyarka", "Amstel"};
            Console.WriteLine("Unsorted: {0}", string.Join(", ", beers));

            //Elements of beers array are of string type which implement IComparable
            Array.Sort(beers, (b1, b2) => (b1.CompareTo(b2)));
            //var result = beers.OrderBy(a => a.Length);
            Console.WriteLine("Sorted: {0}", String.Join(", ", beers));
        }
    }
}
