using System;

class BinaryToDecimal
{
    static void Main()
    {
        double sum = 0;
        int n = 001; // Type your binary number here
        int strn = n.ToString().Length; 
        for (int i = 0; i < strn; i++)
        {
            int lastDigit = n % 10; 
            sum = sum + lastDigit * (Math.Pow(2, i));
            n = n / 10; 
        }
        Console.WriteLine(sum);
    }
}