<?php
// code examle: https://www.geeksforgeeks.org/hamiltonian-cycle-backtracking-6/

class CycleClass
{

    function checkIfSafe($cyc, $tempGraph, $position)
    {
        global $path;

        if ($tempGraph[$path[$position - 1]][$cyc] == 0) {
            return false;
        }

        for ($i = 0; $i < $position; $i++) {
            if ($path[$i] == $cyc) {
                return false;
            }
        }

        return true;

    }


    function cycleArray($tempGraph, $position)
    {
        global $cycle;
        global $path;


        if ($position == $cycle) {
            if ($tempGraph[$path[$position - 1]][$path[0]] == 1) {
                return true;
            } else {
                return false;
            }

        }

        for ($i = 0; $i < $cycle; $i++) {

            if ($this->checkIfSafe($i, $tempGraph, $position)) {
                $path[$position] = $i;

                if ($this->cycleArray($tempGraph, $position + 1) == true) {
                    return true;
                }

                $path[$position] = -1;

            }

        }

        return false;
    }

    function testCycle($tempGraph)
    {
        global $path;
        global $cycle;
        for ($i = 0; $i < $cycle; $i++) {
            $path[$i] = -1;
        }

        $path[0] = 0;

        $flag = ($this->cycleArray($tempGraph, 1));

        if ($flag == false) {
            echo "Solution does not exist \r\n";
        } else {
            echo "The path is: \r\n";
            print_r($path);
        }

    }

}


// testing

 $cycle = 5;
 $path = array();


$graph = array(
    array(
        0, 1, 0, 1, 0
    ),
    array(
        1, 0, 1, 1, 1
    ), array(
        0, 1, 0, 0, 1
    ),
    array(
        1, 1, 0, 0, 1
    ),
    array(
        0, 1, 1, 1, 0
    )
);

$graph1 = array(
    array(
        0, 1, 0, 1, 0
    ),
    array(
        1, 0, 1, 1, 1
    ), array(
        0, 1, 0, 0, 1
    ),
    array(
        1, 1, 0, 0, 0
    ),
    array(
        0, 1, 1, 0, 0
    )
);

$graph2 = array(
    array(0, 10, 0, 5, 0, 0),
    array(0, 0, 5, 0, 0, 15),
    array(0, 0, 0, 10, 5, 0),
    array(0, 10, 0, 0, 10, 0),
    array(0, 5, 0, 0, 0, 0),
    array(0, 0, 0, 0, 0, 0),
);


echo "Graph 1: \r\n";
// success
$cycleGr = new CycleClass();
$cycleGr->testCycle($graph);

echo "Graph 2: \r\n";
// fail
$cycleGr1 = new CycleClass();
$cycleGr1->testCycle($graph1);

echo "Graph 3: \r\n";
// fail
$cycleGr2 = new CycleClass();
$cycleGr2->testCycle($graph2);
