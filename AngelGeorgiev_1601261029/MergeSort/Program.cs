using System;

namespace MergeSort {
    class Program {

        static void Main(string[] args) {

            int[] arr = new int[] { 3133, 8, 56, 7, 422, 2, 6, 1, 9921, 23, 1 };

            MergeSort<int>(arr);

            Console.Write("Sorted Array : ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void MergeSort<T>(T[] arr) where T : IComparable {
            MergeSort(arr, 0, arr.Length / 2, arr.Length);
        }

        static void MergeSort<T>(T[] arr, int left, int mid, int right) where T : IComparable {
            if (right - left > 2) {
                MergeSort(arr, left, left + (mid - left) / 2, mid);
                MergeSort(arr, mid, mid + (right - mid + 1) / 2, right);
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
                if (leftIn < mid && ((rightIn >= right) || arr[leftIn].CompareTo(arr[rightIn]) == -1)) {
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