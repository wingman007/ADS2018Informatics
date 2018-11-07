using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDec
{
    class Program
    {
        /// <summary>
        /// This method is responcible for converting from Decimal to Binary.
        /// </summary>
        static void DecToBin()
        {
            Console.WriteLine("Please enter a decimal number");

            int n = Convert.ToInt32(Console.ReadLine());

            List<int> binaryNum = new List<int>();

            for (int i = 0; n > 0; ++i)
            {
                binaryNum.Add(n % 2);
                n = n / 2;
            }

            foreach (int element in binaryNum)
                Console.Write(element.ToString());

            Console.WriteLine();
        }
        /////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// BinToDec - This method is responcible for converting from Binary to Decimal
        /// </summary>
        static void BinToDec()
        {
            Console.WriteLine("Please enter a binary number");

            int n = Convert.ToInt32(Console.ReadLine());
            long decValue = 0;
            int baseValue = 1;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                n = n / 10;
                decValue += lastDigit * baseValue;
                baseValue *= 2;
            }
            Console.WriteLine(decValue);
        }
        /////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// This method offers to the user to chose whitch of the 2 chonvertion he wants to
        /// use, Binary to decimal or vice versa.
        /// 
        /// </summary>
        static void UserChoise()
        {
            Console.WriteLine("press 1 for converting from decimal to binary" +
                                "or 2 for converting from binary to decimal");
            int userChoise;
            userChoise = Convert.ToInt32(Console.ReadLine());


            switch (userChoise)
            {
                case 1:
                    DecToBin();
                    break;
                case 2:
                    BinToDec();
                    break;
                default:
                    Console.WriteLine("INVALID CHOISE.. PLEASE CHOOSE AGAIN!");
                    UserChoise();
                    break;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            UserChoise();
        }
    }
}
