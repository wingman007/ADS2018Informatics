using System;
public class BinaryToDecimal
{
    public static void Main()
    {
        int n = 1;
        int n2 = 1;
        int dec = 0;
        int i = 1;
        int j;
        int d;

        Console.Write("Enter Binary Number: ");
        n = Convert.ToInt32(Console.ReadLine());
     
        for (j = n; j > 0; j = j / 10)
        {
            d = j % 10;
            if (i == 1)
                n2 *= 1;
            else
                n2 *= 2;

            dec = dec + (d * n2);
            i++;
        }
        Console.Write("\nDecimal Number : {0} \n\n", dec);
    }
}