<?php

// Quick sort between $start and $last indexes of array $a (inplace implementation)
function quickSort(&$a, $start = 0, $last = null) {    
    // Init
    $wall = $start;
	$last = is_null($last) ? count($a) - 1 : $last;
	
	// Nothing to sort
	if($last - $start < 1) {
		return;
	}
    
	// Moving median value to the back to avoid bad performance when sorting an already sorted array
	switchValues($a, (int) (($start + $last) / 2), $last);
	
	// Splitting the array according to comparisons with the last value
    for ($i = $start; $i < $last; $i++) {
        if ($a[$i] < $a[$last]) {
            switchValues($a, $i, $wall);
            $wall++;
        }
    }
    // some recursive stuff

	// Placing last value between the two split arrays
    switchValues($a, $wall, $last);

    // Sorting left of the wall
	quickSort($a, $start, $wall - 1);
    
    // Sorting right of the wall
	quickSort($a, $wall + 1, $last);  
}

// Switch two values identified by keys $i1 and $i2 of $a
function switchValues(&$a, $i1, $i2) {
    if ($i1 !== $i2) {
        $temp = $a[$i1];
        $a[$i1] = $a[$i2];
        $a[$i2] = $temp;
    }
}

// Generate array with random values
$arr = [];
$size = 10000;
for ($i = 0; $i < $size; $i++) {
    $arr[] = (int) (rand() / (1000000000 / $size));
}
// copying the array
$arr2 = $arr;

//print_r($arr);

// Measuring function's performance
$t1 = microtime(true);
quickSort($arr);
$t2 = microtime(true);

$t3 = microtime(true);
sort($arr2);
$t4 = microtime(true);

// Printing stats

$tQuickSort =  round(($t2 - $t1) * 1000 * 1000) / 1000;
$tNativeFunction = round(($t4 - $t3) * 1000 * 1000) / 1000;
echo  "Sorted $size elements in {$tQuickSort}ms by quickSort function" . PHP_EOL;
echo  "Sorted $size elements in {$tNativeFunction}ms by native sort function" . PHP_EOL;