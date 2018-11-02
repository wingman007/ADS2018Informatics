#  k smallest elements in an array

### Prerequisites

This task is from the "Programming = ++ Algorithms" Book
here is a link from where you can download the book: http://www.programirane.org/download-now/ .
Task number is 7.37, on page 460.

## Details

The program is writen in PHP programming language.

Here is an online compiler where you can run the program: https://rextester.com/l/php_online_compiler

Just copy the code and paste it in the compiler:

<?php
function getMax( $array )
{
   $n 	=	count( $array );
   $max =	$array[0];
   $arr =	[];
   for ( $i = 1; $i < $n; $i++ )
   {
       if ( $max < $array[$i] )
       {
           $max =	$array[$i];
       }
   }

   for ( $i = 1; $i < $n; $i++ )
   {
       if ( $max == $array[$i] )
       {
           $a =	$i;
       }
   }

    array_push( $arr, $max, $a );

    return $arr;
}

function getMin( $array )
{ 
   $n 	=	count($array);
   $min =	$array[0];
   for ( $i = 1; $i < $n; $i++ )
   {
       if ( $min > $array[$i] )
       {
           $min =	$array[$i];
       }
    }
    return $min;
}

function numpat( $n ) 
{
    $num =	$n[0];

    for ( $i = 0; $i < count( $n ); $i++ )
    { 
        for ( $j = 0; $j <= $i; $j++ )
        {
            $num =	$n[$j];
            echo $num . " ";
        } 
        echo "\n";
    } 
} 

$array = array( 56, 12, 89, 65, 61, 36, 45, 23, 55 );
print_r( "Max: " . getMax( $array )[0] );

echo( "\n" );
echo( "Min: " . getMin( $array ) );
echo( "\n" );

echo( "\nSplit Array and then sort the left side\n" );
$test = array_slice($array, 0, getMax( $array )[1] );
sort( $test );
print_r( $test );
print_r( array_slice( $array, getMax( $array )[1], count( $array ) ) );

echo( "\nSorted Array \n" );
sort( $array );
for( $i = 0; $i < 5; $i++ )
{
    echo "[" . $i . "] = " . $array[$i] . "\n";
}

echo( "\nPyramid \n" );
numpat( $array );