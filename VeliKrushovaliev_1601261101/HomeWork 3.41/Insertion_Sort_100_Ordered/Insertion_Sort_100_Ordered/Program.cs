using System;

namespace Insertion_Sort_100_Ordered
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100] { 11, 136, 403, 755, 767, 923, 959, 1099, 1143, 1225,
                1237, 1260, 1414, 1528, 1959, 2036, 2067, 2198, 2326,
                2334, 2519, 2538, 2589, 2661, 2741, 2779, 2903, 2986,
                3090, 3195, 3200, 3245, 3281, 3380, 3432, 3484, 3510,
                3544, 3567, 3615, 3727, 3765, 3830, 3841, 3932, 3936,
                4120, 4349, 4385, 4387, 4427, 4696, 4789, 4863, 4885,
                5143, 5222, 5266, 5335, 5337, 5588, 5663, 5664, 6059,
                6071, 6176, 6204, 6223, 6230, 6502, 6600, 6689, 7085,
                7507, 7536, 7647, 7730, 7767, 7805, 7852, 7986, 8054,
                8467, 8681, 8746, 8756, 8775, 8784, 9084, 9085, 9172,
                9214, 9250, 9297, 9430, 9475, 9709, 9744, 9864, 9911 };
            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(InsertionSort(numbers));
            Console.WriteLine("\n");
        }

        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }

    }
}
