using System;

namespace CharSequenceFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new[] { 'a', 'e', 'x', 't', 'e', 's', 'p', 'u', 'i', 'x', 't', 'e', 's', 't', 'q', 'e' };

            Console.Write("Please, enter sequence (as word) to be found: ");
            var sequence = Console.ReadLine();


            var found = IsExist(array, sequence);

            Console.WriteLine(found);
        }

        private static bool IsExist(char[] array, string sequence)
        {
            var seqArr = sequence.ToCharArray();

            var seqIndex = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == seqArr[seqIndex])
                {
                    seqIndex++;
                    if (seqIndex == seqArr.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    seqIndex = 0;
                }
            }

            return false;
        }
    }
}
