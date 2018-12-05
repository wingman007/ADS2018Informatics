using System;
using System.Collections.Generic;

namespace reacheble_radius
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<NaturalNumber> naturalNumbets = new List<NaturalNumber>();
            List<NaturalNumber> resultList;
            int k = rnd.Next(100, 1000);
            int d = rnd.Next(0, 100);
            GenerateNumber(naturalNumbets, 10);
            resultList=Search(naturalNumbets, k, d);
            Console.WriteLine("[ k ] is : "+k);
            Console.WriteLine("[ d ] is : " + d);
            Console.WriteLine("Generated List is :");
            foreach (NaturalNumber item in naturalNumbets)
            {
                Console.Write(item.value + " | ");
            }
            Console.WriteLine();
            if (resultList.Count != 0)
            {
                Console.WriteLine("The elements that satisfy the condition |k - x.key | <= d are:");
                foreach (NaturalNumber item in resultList)
                {
                    Console.Write(item.value+" | ");
                }
            }
            else
            {
                Console.WriteLine("No such element!");
            }

            Console.ReadLine();
        }
        public static void GenerateNumber(List<NaturalNumber>naturaleNumbers,int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                NaturalNumber naturalNumber = new NaturalNumber(rnd.Next(100, 1000), rnd.Next(0, 100));
                naturaleNumbers.Add(naturalNumber);
            }
        }

        public static List<NaturalNumber> Search(List<NaturalNumber> naturaleNumbers,int k,int d)
        {
            List<NaturalNumber> resultList = new List<NaturalNumber>();
            foreach (NaturalNumber x in naturaleNumbers)
            {
                if (Math.Abs(k - x.key) <= d)
                {
                    resultList.Add(x);
                }
            }
            return resultList;
        }
    }
}
