#  Split String

### Prerequisites

This task is from the "Programming = ++ Algorithms" Book.
Here is a link from where you can download the book: http://www.programirane.org/download-now/ .
Task number is 8.114, on page 568.

## Details

The program is writen in PHP programming language.

Here is an online compiler where you can run the program: https://rextester.com/l/php_online_compiler

Just copy the code and paste it in the compiler:
```
<?php

function splitString( string $data, int $number ): array
{
    $new_string =   str_split( $data, $number );
    return $new_string;    
}

function splitStringOnHalf( string $data ) : array
{
    $number     =   strlen( $data ) / 2 + 0.5;
    $new_string =   str_split( $data, $number );
    
    $arr = [];
    array_push( $arr, $new_string );
    
    for( $i = 0; $i < count( $new_string ); $i++ )
    {
        $test           =   strlen( $new_string[$i] ) / 2;
        $new_strings    =   str_split( $new_string[$i], $test );
        array_push( $arr, $new_strings );
    }
    return $arr;
}

function splitStringIntoChunks( string $data ) : array
{
    $arr    =   [];
    $arr2   =   [];
    $arr3   =   [];
    $text   =   explode( " ", $data );

    for( $i = 0; $i < count( $text ); $i++ )
    {
        if( strlen( $text[$i] ) <= 3 )
        {
            array_push( $arr, $text[$i] );
        }
        
        if( strlen( $text[$i] ) > 3 )
        {
            array_push( $arr2, $text[$i] );
        }
    }
        array_push( $arr3, $arr, $arr2 );
        return $arr3;
}

$data   =   "The quick brown fox jumps over the lazy dog";
$number =   5;

echo "\n--- Split a string on chunks by 5 ---\n";
$result =   splitString( $data, $number );
print_r( $result );

echo "\n--- Split a string on half then split the left and right side on half ---\n";
$resultTwo =    splitStringOnHalf( $data );
print_r( $resultTwo );

echo "\n";
$resultThree =  splitStringIntoChunks( $data );
print_r( $resultThree );

```