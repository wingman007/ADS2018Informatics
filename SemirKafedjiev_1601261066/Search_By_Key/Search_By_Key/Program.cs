using System;

namespace Search_By_Key
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Fury", "Wilder", "Kubrat", "Joshua" };
            string match = Array.Find(names, delegate (string name)
            { return name.Contains("K"); });
            Console.WriteLine(match);
        }
    }
}

   
