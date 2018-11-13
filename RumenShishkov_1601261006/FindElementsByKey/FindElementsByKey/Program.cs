using System;
using System.Collections.Generic;

namespace FindElementsByKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>
            {
                { "person", "Pesho" },
                { "make", "Porsche" }
            };

            FindByKey(dictionary, "make");// search for item with key make
            FindByKey(dictionary, "person");// search for item with key person
            FindByKey(dictionary, "animal");// search for missing key
        }

        static void FindByKey(Dictionary<string, string> dictionary, string key)
        {
            if (dictionary.ContainsKey(key))
            {
                Console.WriteLine(dictionary[key]);
                return;
            }
            Console.WriteLine($"item with key {key} not found");
        }
    }
}
