// Nodejs is required to run this portion of code
let unsortedArray = createRandomArray();
console.log("Unsorted array");
console.log(unsortedArray);// print the unsorted array

let sortedArray = SelectionSort(unsortedArray); //sort the array using selection sort
console.log("Sorted array");
console.log(sortedArray);// print the sorted array

function createRandomArray() {
    let array = new Array(parseInt(Math.random() * 10 + 6)); //create an array with random length

    for (let i = 0; i < array.length; i++) {//fill the array with random values
        array[i] = parseInt(Math.random() * 100);
    }
    return array;
}

function SelectionSort(array) {// selection sort implementation
    let sortedArray = [...array];// fallowed javascript pattern to never mutate object directly
    for (let i = 0; i < sortedArray.length; i++) {
        let minNumberIndex = i;
        for (let j = i + 1; j < sortedArray.length; j++) {
            if (sortedArray[j] < sortedArray[minNumberIndex]) {
                minNumberIndex = j;
            }
        }
        if (minNumberIndex != i) {
            let temp = sortedArray[i];
            sortedArray[i] = sortedArray[minNumberIndex];
            sortedArray[minNumberIndex] = temp;
        }
    }
    return sortedArray;
}

