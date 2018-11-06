using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllElementsByKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("txt", "word.exe");
            table.Add("jpeg", "photoshop.exe");
            table.Add("bmp", "paint.exe");
            table.Add("md", "README.md");

            printTable(table);
        }

        private static void printTable(Hashtable table)
        {
            foreach (var item in table)
            {
                Console.WriteLine("Element: " + item.ToString());
            }
        }
    }
}
