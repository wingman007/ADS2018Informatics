using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
          
                int[] arr = { 97, 38, 58, 76, 69, 24, 27, };

                int temp = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

                Console.ReadKey();
            
        }
    }
}
    

