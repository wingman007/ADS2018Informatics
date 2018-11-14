using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchByKey
{
    public class Program
    {
        static IDictionary dictionary = new Dictionary<string, string>();

        public static void Main(string[] args)
        {

            dictionary.Add("text", "some text");
            dictionary.Add("jpeg", "some photo");
            dictionary.Add("mov", "some movie");

            FindEntryValueByKey("jpeg");

            Console.ReadLine();
        }

        private static void FindEntryValueByKey(string key)
        {
            foreach (DictionaryEntry entry in dictionary)
            {
                if (entry.Key.Equals(key))
                {
                    Console.WriteLine(entry.Value.ToString());
                    return;
                }
            }

            Console.WriteLine("No element with \"{0}\" key was found.", key);
        }
    }
}