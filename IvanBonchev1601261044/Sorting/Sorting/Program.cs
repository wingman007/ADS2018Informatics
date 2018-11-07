using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            double b = new double();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter arr[" + i +"]:");
                arr[i] = Convert.ToDouble(Console.ReadLine());
                
            }
            for (int i = 1; i < n; i++)
            {
                b = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > b)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = b;
            }
            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[" + i + "]:"+arr[i]);
            }
            Console.ReadLine();


            
        }
    }
}
