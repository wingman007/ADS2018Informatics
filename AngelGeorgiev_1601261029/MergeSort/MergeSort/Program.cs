using System;

namespace MergeSort
{
    class Program
    {

        static void Main(string[] args) {

            int[] arr = new int[] { 4, 999, 1, 22, 4, 2, 120, 3213, 35, 23, 24 };

            MergeSort<int>(arr);

            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }

        static void MergeSort<T>(T[] arr) where T : IComparable {
            MergeSort(arr, 0, arr.Length / 2, arr.Length - 1);
        }

        static void MergeSort<T>(T[] arr, int left, int mid, int right) where T : IComparable {
            Console.Write(left + " " + mid + " " + right + " ----- ");
            for (int i = left; i < right; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            if (right - left > 2)
            {
                MergeSort(arr, left, left + (mid - left) / 2, mid);
                MergeSort(arr, mid, mid + (right - mid) / 2, right);
            }

            Combine(arr, left, mid, right);
        }

        static void Combine<T>(T[] arr, int left, int mid, int right) where T : IComparable {
            if (left == right) {
                return;
            }

            int leftIn = left;
            int rightIn = mid;

            T[] temp = new T[right - left];
            int counter = 0;

            while (leftIn < mid || rightIn < right) {
                if (leftIn < mid && arr[leftIn].CompareTo(arr[rightIn]) == -1) {
                    temp[counter] = arr[leftIn];
                    leftIn++;
                }
                else {
                    temp[counter] = arr[rightIn];
                    rightIn++;
                }
                counter++;
            }

            for (int i = 0; i < right - left; i++) {
                arr[left + i] = temp[i];
            }
        }
    }
}
