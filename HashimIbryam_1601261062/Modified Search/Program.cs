using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedSearch
{
    class Program
    {
        static int binarySearch(int[] arr, int FirstIndex, int LastIndex, int Searchvalue)
        {
            if (LastIndex >= FirstIndex)
            {
                int mid = FirstIndex + (LastIndex - FirstIndex) / 2;

                if (arr[mid] == Searchvalue)
                    return mid;

                if (arr[mid] > Searchvalue)
                    return binarySearch(arr, FirstIndex, mid - 1, Searchvalue);

                return binarySearch(arr, mid + 1, LastIndex, Searchvalue);
            }


            return -1;
        }

        static int countOccurrences(int[] arr, int ArrayLength, int Searchvalue)
        {
            int ind = binarySearch(arr, 0, ArrayLength - 1, Searchvalue);

            if (ind == -1)
                return 0;

            int count = 1;
            int left = ind - 1;
            while (left >= 0 &&
                   arr[left] == Searchvalue)
            {
                count++;
                left--;
            }

            int right = ind + 1;
            while (right < ArrayLength &&
                   arr[right] == Searchvalue)
            {
                count++;
                right++;
            }

            return count;
        }

        public static void Main()
        {

            int[] arr = { 1, 2, 2, 2, 2, 3, 4, 7, 8, 8 };

            int ArrayLength = arr.Length;
            int Searchvalue = 8;

            Console.Write("Element " + Searchvalue + " occurs " + countOccurrences(arr, ArrayLength, Searchvalue) + " times.\n");
        }
    }
}