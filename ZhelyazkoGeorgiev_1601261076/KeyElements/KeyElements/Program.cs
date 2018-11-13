using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyElements
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Tuple<int, string>>
            {
                Tuple.Create(2, "kapuchino"),
                Tuple.Create(2, "meow"),
                Tuple.Create(2, "blqk"),
                Tuple.Create(3, "bro"),
                Tuple.Create(2, "qko")
            };

            // calling the list
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nThe duplicates are: \n");
            
            // printing out the same ints with their strings
            var lookup = list.ToLookup(t => t.Item1, t => t.Item2);

            foreach (var kv in lookup)
            {
                Console.WriteLine(kv.Key + " - " + string.Join("; ", kv));
            }

            Console.ReadKey();
        }

    }
}
