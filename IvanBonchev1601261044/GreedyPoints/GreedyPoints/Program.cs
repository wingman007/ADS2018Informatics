using System;

namespace GreedyPoints
{
    class Program
    {
        static void InsertPoints(double[] array, int n)
        {
            int m = n - 1;
            array[0]=3.14;
            Console.WriteLine("Enter " + m +" points each bigger than 3,14:");

            Console.WriteLine("Point 1 is automatically set to Pi=3,14");
            for (int i = 1; i < n; i++)
            {
                Console.Write("Point "+(i+1)+":");
                array[i] = Convert.ToDouble(Console.ReadLine());
                while (array[i] < 3.14)
                {
                    Console.WriteLine("Value invalid. Try again with number bigger than pi=3,14");
                    Console.Write("Point " + (i+1) + ":");
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        static void Sort(double[] array)
        {
            
            for (int i = 0; i <= array.Length; i++)
            {
                for (int j = i + 1; j <= array.Length - 1; j++)
                {

                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }

        }

        static void Display(double[] array, int n)
        {
            double b = 0;
            Console.Write("0");
            for (int i = 0; i < n; i++)
            {
                double c = array[i];
                for(double j = b; j <= c; j = j + 0.1)
                {
                    Console.Write(".");
                }
                Console.Write(array[i]);
                b = array[i];
            }


        }

        static void IntervalCounter(double[] array,int n)
        {
            int intervals = 1, pr = 0;
            double intervalStart=3.14;
            double intervalEnd = intervalStart+1;
            int i = 0;
            Console.Write("Interval " + intervals + " covers points:");
            do
            {
                if (array[i] >= intervalStart && array[i] <= intervalEnd)
                {
                    Console.Write((i + 1) + ",");
                    i++;
                    pr++;
                    
                }
                else
                {
                    Console.Write("\b \b");
                    intervals++;
                    intervalStart = array[i];
                    intervalEnd = intervalStart + 1;
                    Console.Write("\n");
                    Console.Write("Interval " + intervals + " covers points:");
                }

            }
            while (pr < n);

            Console.Write("\b \b");
            Console.Write("\n");
            Console.WriteLine("Intervals needed for all points="+intervals);
              
        }


        static void Main(string[] args)
        {
            Console.Write("Enter number for points:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            InsertPoints(arr, n);
            Sort(arr);
            Display(arr, n);
            Console.WriteLine();
            IntervalCounter(arr, n);

            Console.Read();
        }
    }
}
