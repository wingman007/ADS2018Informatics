using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main( string[] args )
        {
            BinaryToDecimal();
            DecimalToBinary();
        }

        static void BinaryToDecimal()
        {
            int num, binary_val, decimal_val = 0, base_val = 1, rem;

            Console.Write( "Enter a Binary Number( 1s and 0s ) : " );

            num         =   int.Parse( Console.ReadLine() );
            binary_val  =   num;

            while ( num > 0 )
            {
                rem         =   num % 10;
                decimal_val =   decimal_val + rem * base_val;
                num         =   num / 10;
                base_val    =   base_val * 2;
            }
            Console.Write( "The Binary Number is : " + binary_val );
            Console.Write( "\nIts Decimal Equivalent is : " + decimal_val );
            Console.ReadLine();
        }

        static void DecimalToBinary()
        {
            string answer;
            string result;

            Console.Write( "Enter a Decimal number : " );
            answer = Console.ReadLine();

            int num =   Convert.ToInt32( answer );
            result  =   "";
            while ( num > 1 )
            {
                int remainder   =   num % 2;
                result          =   Convert.ToString(remainder) + result;
                num /=  2;
            }
            result = Convert.ToString( num ) + result;
            Console.WriteLine( "Binary: {0}", result );
        }
    }
}