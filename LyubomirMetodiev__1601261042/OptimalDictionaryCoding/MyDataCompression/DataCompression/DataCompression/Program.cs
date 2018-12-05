using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompression
{
    class Program
    {
        static IDictionary dictionary = new Dictionary<char, List<int>>();

        static List<char> charsChecked = new List<char>();

        //static bool isChecked = false;

        static void GetUserStringInput(out string userInput)
        {
            Console.Write("Input string for compression: ");
            userInput = Console.ReadLine();
            Console.WriteLine($"-> {userInput.Length * 8} bits needed ");
            Console.WriteLine();
        }

        private static void PrintIndexes(List<int> repeatsIndex)
        {
            foreach (var item in repeatsIndex)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void PrintCompressedString()
        {
            int bits = 0;
            {
                Console.Write("\n \nThe compressed string : ");
                foreach (DictionaryEntry item in dictionary)
                {
                    Console.Write(item.Key);
                    bits++;

                }
                Console.WriteLine($"\n-> bits needed {bits * 8}");
            }
        }

        private static void CompressString(string userInput)
        {
            bool isChecked = false;
            {
                for (int j = 0; j < userInput.Length; j++)
                {
                    isChecked = false;
                    char currentChar = userInput[j];
                    int repeats = 0;

                    //for each cycle the list to check if the char is already added to the list

                    foreach (var item in charsChecked)
                    {
                        if (item == currentChar)
                        {
                            isChecked = true;
                            break;
                        }
                    }

                    if (isChecked)
                    {
                        continue;
                    }
                    else
                    {
                        List<int> repeatsIndex = new List<int>();

                        //nested for cycle to get the repeats of the char in the whole string and the indexes of the repeated chars to list
                        for (int i = 0; i < userInput.Length; i++)
                        {
                            if (userInput[j] == userInput[i])
                            {
                                repeats++;
                                repeatsIndex.Add(i);
                            }
                        }

                        Console.Write($"{userInput[j]} : repeated {repeats} times at indexes : ");

                        PrintIndexes(repeatsIndex);


                        dictionary.Add(userInput[j], repeatsIndex);

                        //adding the checked char
                        charsChecked.Add(userInput[j]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string userInput;
            GetUserStringInput(out userInput);

            CompressString(userInput);

            //printing using the keys from the dictionary 
            PrintCompressedString();

            Console.ReadLine();
        }

        
    }
}
