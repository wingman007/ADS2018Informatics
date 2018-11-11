using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBinaryToDecimalAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber;

            //input the decimal number
            do
            {
                Console.Write("Enter a Decimal Number : ");
                decimalNumber = int.Parse(Console.ReadLine());
            } while (decimalNumber < 0);

            //using List to store the digits of the binaryNumber      
            List<int> binaryNumber = new List<int>();

            //using helping value to store the result for the division by 2 in the "do-while cycle"
            int helpValue = decimalNumber*2;

            //convert decimal to binary     
            do
            {
                if (helpValue % 2 == 0)
                {
                    binaryNumber.Add(0);
                }
                else
                {
                    binaryNumber.Add(1);
                }
                helpValue /= 2;

            } while (helpValue != 0);

            Console.Write("The Binary Number is : ");

            if (decimalNumber == 0)
            {
                Console.Write("0");
            }
            else
            {
                //using reverse "for cycle" to show the appropriate binary number
                for (int index = binaryNumber.Count - 1; index > 0; index--)
                {
                    Console.Write(binaryNumber[index]);
                }
            }
            Console.WriteLine();


            //convert binary to decimal
            Console.Write("Enter a Binary Number : ");
            string binaryNumString = Console.ReadLine();

            int length = Convert.ToString(binaryNumString).Length;

            int[] binaryNumberArray = new int[length];

            //transferring the String Input to an Array and also verify the Binary Number
            bool isCorrect = true;

            for (int i = 0; i < length; i++)
            {
                if(binaryNumString[i] == 49)
                {
                    binaryNumberArray[i] = 1;
                }
                else if (binaryNumString[i] == 48)
                {
                    binaryNumberArray[i] = 0;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Wrong binary Number !");
                    break;
                }              
            }

            double  Sum = 0;
            //using math.pow for every element of the Array to get the decimal number 
            for (int i = 0; i <length; i++)
            {
                Sum += binaryNumberArray[i] * Math.Pow(2, length - i - 1);
            }
            if (isCorrect)
            {
                Console.WriteLine($"The decimal number is : {Sum}");
            }
            Console.Read();
        }
    }
}
