using System;

namespace Insertion_Sort_100_Messy
{
    class Program
    {
            static void Main(string[] args)
            {
                int[] numbers = new int[100] { 8934, 3240, 8164, 1091, 4364, 8322, 2547, 9456, 716, 1942,
                    6212, 7938, 8317, 9356, 5937, 3460, 6048, 2489, 268, 6103,
                    2928, 4721, 3153, 1356, 9628, 5281, 9853, 5349, 9266, 7257,
                    7619, 4599, 929, 4547, 772, 5296, 4498, 3722, 6480, 3272,
                    6246, 792, 8316, 8168, 3858, 4430, 442, 6359, 7904, 3462,
                    986, 3531, 9303, 9889, 697, 4334, 9574, 8196, 2813, 3282,
                    7536, 8406, 1228, 4318, 9692, 4377, 8297, 5898, 5060, 2874,
                    8366, 1166, 9223, 2467, 5179, 3761, 2014, 4563, 9044, 7043,
                    6062, 6645, 4624, 6403, 1970, 889, 6677, 8783, 6031, 6620,
                    2355, 3029, 7550, 8610, 5921, 9092, 1054, 3314, 2617, 9663 };
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
