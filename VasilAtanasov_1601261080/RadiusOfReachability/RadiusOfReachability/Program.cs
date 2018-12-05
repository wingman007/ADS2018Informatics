using System;
using System.Collections.Generic;

namespace RadiusOfReachability
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int k = rand.Next(100, 1000);
            int d = rand.Next(0, 100);

            Console.WriteLine("The key number is: {0}", k);
            Console.WriteLine("The natural number is: {0}", d);


            var list = generate();
            printResult(search(d, k, list));

        }

        public static void printResult(List<NaturalNumber> list)
        {
            Console.WriteLine("data\t, key");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].data + "\t, " + list[i].key);
            }
        }

        public static List<NaturalNumber> generate()
        {
            List<NaturalNumber> list = new List<NaturalNumber>();
            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                list.Add((new NaturalNumber(rand.Next(100), rand.Next(100, 1000))));
            }
            return list;
        }

        public static List<NaturalNumber> search(int d, int k, List<NaturalNumber> list)
        {
            List<NaturalNumber> res = new List<NaturalNumber>();
            foreach (var item in list)
            {
                if (Math.Abs(k - item.key) <= d)
                {
                    res.Add(item);
                }
            }
            return res;
        }
    }

    public class NaturalNumber
    {
        public int data;
        public int key;

        public NaturalNumber(int data, int key)
        {
            this.data = data;
            this.key = key;
        }
    }
}
