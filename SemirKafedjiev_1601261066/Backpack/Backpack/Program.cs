using System;
using System.Linq;

namespace Backpack
{
    class Program
    {
        public static void Main()

        {

            int[] v = { 1, 2, 3 }; // The value of each item

            int[] w = { 1, 2, 3 }; // The weight of each item

            Console.WriteLine("xxxxxmaximum value is: {0}", fetch(v, w, 5));

        }



        private static int fetch(int[] v, int[] w, int j) //The number of initial i= items, the total capacity of j= knapsack

        {

            int i = w.Count() - 1;

            return fetch(v, w, i, j);

        }



        static int fetch(int[] v, int[] w, int i, int j)  //The number of initial i= items, the total capacity of j= knapsack

        {

            if (i == -1)

                return 0;

            if (j >= w[i])

            { // The remaining space can drop items I Backpack

                int v1 = fetch(v, w, i - 1, j - w[i]) + v[i]; //The value of the I items into the can get

                int v2 = fetch(v, w, i - 1, j);             //Don't get the I value of an item

                if (v1 > v2)

                {

                    return v1;

                }

                else

                {

                    return v2;

                }

            }

            else

                return fetch(v, w, i - 1, j);

        }

    }
}
