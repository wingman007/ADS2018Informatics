using System;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int length = 3;
            const int cycles = 1000000;

            Random r = new Random();

            List<int[]> permutations = new List<int[]>();

            // Build all the permutations
            {
                var numbers = new int[length];
                Reset(numbers);

                // We calculate all the possible permutations. We will use them
                // later, to see if each one happens the same number of times
                permutations.Add((int[])numbers.Clone());

                while (!NextPermutation(numbers))
                {
                    permutations.Add((int[])numbers.Clone());
                }
            }

            Calculate("Fisher-Yates backward", length, cycles, permutations.AsReadOnly(), nums => Shuffle1(nums, r));
            Calculate("Fisher-Yates forward", length, cycles, permutations.AsReadOnly(), nums => Shuffle2(nums, r));
            Calculate("Naive", length, cycles, permutations.AsReadOnly(), nums => NaiveShuffle(nums, r));
            Calculate("r.Next()", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next()));
            Calculate("r.Next(int.MaxValue)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(int.MaxValue)));
            Calculate("r.Next(1)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(1)));
            Calculate("r.Next(2)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(2)));
            Calculate("r.Next(4)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(4)));
            Calculate("r.Next(8)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(8)));
            Calculate("r.Next(16)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(16)));
            Calculate("r.Next(32)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(32)));
            Calculate("r.Next(64)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(64)));
            Calculate("r.Next(128)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(128)));
            Calculate("r.Next(256)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(256)));
            Calculate("r.Next(512)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(512)));
            Calculate("r.Next(1024)", length, cycles, permutations.AsReadOnly(), nums => WithOrderBy(nums, () => r.Next(1024)));
        }

        #region Algorithms

        
        public static void Shuffle1<T>(T[] array, Random r)
        {
            // Shuffles in place! Compatible with arrays (but a little
            // slower, because it is using the IList<T> interface instead of
            // using direct array accessors)
            // Using the backward algorithm of the Wiki.
            // With C# I could have used the forward algorithm.
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);

                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        
        public static void Shuffle2<T>(T[] array, Random r)
        {
            // Shuffles in place! Compatible with arrays (but a little
            // slower, because it is using the IList<T> interface instead of
            // using direct array accessors)
            // Using the forward algorithm of the Wiki.
            for (int i = 0; i < array.Length; i++)
            {
                int j = r.Next(i, array.Length);

                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        
        public static void NaiveShuffle<T>(T[] array, Random r)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = r.Next(array.Length);

                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // OrderBy shuffler, receives a function orderer that should be
        // something like () => r.Next()
        public static void WithOrderBy<T>(T[] array, Func<int> orderer)
        {
            var enu = array.OrderBy(x => orderer());

            // OrderBy creates a new "collection". We have to overwrite the
            // old one
            int i = 0;

            foreach (T el in enu)
            {
                array[i] = el;
                i++;
            }
        }

        #endregion

      
        public static bool NextPermutation<T>(T[] elements) where T : IComparable<T>
        {
            // More efficient to have a variable instead of accessing a property
            var count = elements.Length;

            // Indicates whether this is the last lexicographic permutation
            var done = true;

            // Go through the array from last to first
            for (var i = count - 1; i > 0; i--)
            {
                var curr = elements[i];

                // Check if the current element is less than the one before it
                if (curr.CompareTo(elements[i - 1]) < 0)
                {
                    continue;
                }

                // An element bigger than the one before it has been found,
                // so this isn't the last lexicographic permutation.
                done = false;

                // Save the previous (bigger) element in a variable for more efficiency.
                var prev = elements[i - 1];

                // Have a variable to hold the index of the element to swap
                // with the previous element (the to-swap element would be
                // the smallest element that comes after the previous element
                // and is bigger than the previous element), initializing it
                // as the current index of the current item (curr).
                var currIndex = i;

                // Go through the array from the element after the current one to last
                for (var j = i + 1; j < count; j++)
                {
                    // Save into variable for more efficiency
                    var tmp = elements[j];

                    // Check if tmp suits the "next swap" conditions:
                    // Smallest, but bigger than the "prev" element
                    if (tmp.CompareTo(curr) < 0 && tmp.CompareTo(prev) > 0)
                    {
                        curr = tmp;
                        currIndex = j;
                    }
                }

                // Swap the "prev" with the new "curr" (the swap-with element)
                elements[currIndex] = prev;
                elements[i - 1] = curr;

                // Reverse the order of the tail, in order to reset it's lexicographic order
                for (var j = count - 1; j > i; j--, i++)
                {
                    var tmp = elements[j];
                    elements[j] = elements[i];
                    elements[i] = tmp;
                }

                // Break since we have got the next permutation
                // The reason to have all the logic inside the loop is
                // to prevent the need of an extra variable indicating "i" when
                // the next needed swap is found (moving "i" outside the loop is a
                // bad practice, and isn't very readable, so I preferred not doing
                // that as well).
                break;
            }

            // Return whether this has been the last lexicographic permutation.
            return done;
        }

        // Reset an array to a sequence 0... array.Length - 1
        public static void Reset(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

        // Simple array IEqualityComparer
        public class ArrayComparer : IEqualityComparer<int[]>, IComparer<int[]>
        {
            public static readonly ArrayComparer Instance = new ArrayComparer();

            protected ArrayComparer()
            {
            }

            public bool Equals(int[] x, int[] y)
            {
                return Compare(x, y) == 0;
            }

            public int GetHashCode(int[] obj)
            {
                unchecked
                {
                    int hash = 17;

                    if (obj != null)
                    {
                        for (int i = 0; i < obj.Length; i++)
                        {
                            hash = hash * 23 + obj[i].GetHashCode();
                        }
                    }

                    return hash;
                }
            }

            public int Compare(int[] x, int[] y)
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        return 0;
                    }

                    return -1;
                }

                if (y == null)
                {
                    return 1;
                }

                int min = Math.Min(x.Length, y.Length);

                for (int i = 0; i < min; i++)
                {
                    int cmp = x[i].CompareTo(y[i]);

                    if (cmp != 0)
                    {
                        return cmp;
                    }
                }

                return x.Length.CompareTo(y.Length);
            }
        }

        // Executes cycles shuffles on a int[length] array, using shuffler.
        // Shows the number of times each of the permutations happened, with
        // a comparison to the first of the permutations
        public static void Calculate(string title, int length, int cycles, IReadOnlyList<int[]> permutations, Action<int[]> shuffler)
        {
            var numbers = new int[length];
            Reset(numbers);

            var dict = permutations.ToDictionary(x => x, x => 0, ArrayComparer.Instance);

            for (int i = 0; i < cycles; i++)
            {
                Reset(numbers);

                shuffler(numbers);

                dict[numbers]++;
            }

            Console.WriteLine(title);

            var dict2 = dict.OrderBy(x => x.Key, ArrayComparer.Instance).ToArray();

            // All the % are based on the first element
            foreach (var kv in dict2)
            {
                Console.WriteLine("[{0}]: {1} ({2:P2})", string.Join(",", kv.Key), kv.Value, ((double)kv.Value) / dict2[0].Value - 1);
            }

            Console.WriteLine();
        }
    }
}
