using System;
using System.Collections.Generic;
using System.Linq;

class MaxNonDecreaseSequence
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var resultList = new List<int>();
        int length = 0;
        string str = "";
        string sequence = "";
        int combinations = (int)Math.Pow(2, (input.Length));
        Console.WriteLine();

        for (int i = 1; i <= combinations; i++)
        {
            int[] bits = new int[input.Length];

            for (int k = 0; k < input.Length; k++)
            {
                int temp = 0;
                bits[k] = (i >> k) & 1;
                temp = bits[k] * input[k];
                if (temp != 0)
                {
                    resultList.Add(temp);
                }

            }
            int num = 0;
            int currentcount = 0;
            for (int j = 0; j < resultList.Count; j++)
            {
                if (resultList[j] >= num)
                {
                    str += resultList[j] + " ";
                    currentcount++;
                    num = resultList[j];
                }
            }
            if (currentcount > length)
            {
                sequence = str;
                length = currentcount;
            }
            resultList.Clear();
            str = string.Empty;
        }
        Console.WriteLine(sequence);
    }
}