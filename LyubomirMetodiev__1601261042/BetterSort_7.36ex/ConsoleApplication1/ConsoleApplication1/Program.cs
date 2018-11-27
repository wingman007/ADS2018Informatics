using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        //
        private static void heapSort<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            buildMaxHeap(array);

            for (int i = heapSize - 1; i >= 1; i--)
            {
                swap(array, i, 0);
                heapSize--;
                sink(array, heapSize, 0);
            }
        }

        private static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sink(array, heapSize, i);
            }
        }

        private static void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            if (getLeftKidPos(toSinkPos) >= heapSize)
            {
                // No left kid => no kid at all
                return;
            }


            int largestKidPos;
            bool leftIsLargest;

            if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSinkPos);
                leftIsLargest = false;
            }



            if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestKidPos);

                if (leftIsLargest)
                {
                    sink(array, heapSize, getLeftKidPos(toSinkPos));

                }
                else
                {
                    sink(array, heapSize, getRightKidPos(toSinkPos));
                }
            }

        }

        private static void swap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        private static int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        private static void printArray<T>(T[] array)
        {

            foreach (T t in array)
            {
                Console.Write(t.ToString() + ' ');
            }

        }

        public static void Main(string[] args)
        {           
            //William's Sort
            int[] firstArray = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original Array Elements :");
            printArray(firstArray);

            DateTime start = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                heapSort(firstArray);
            }
            DateTime end = DateTime.Now;

            Console.WriteLine("\n\nSorted Array Elements :");
            printArray(firstArray);           
           
            Console.WriteLine($"\n\n->First sort time elapsed: {end - start}\n");
            //Hoop's Sort

           
            int[] secondArray = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            
            Console.WriteLine("Original Array Elements :");
            printArray(secondArray);

            start = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                Quick_Sort(secondArray, 0, secondArray.Length - 1);
            }
            end = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("\nSorted Array Elements :");

            printArray(secondArray);
            Console.WriteLine($"\n\n->Second sort time elapsed: {end-start}\n");
            Console.ReadLine();
        }
    }
}
