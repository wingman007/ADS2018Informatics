let unsortedArray = createRandomArray();
console.log("Unsorted array");
console.log(unsortedArray);

let sortedArray = SelectionSort(unsortedArray);
console.log("Sorted array");
console.log(sortedArray);

function createRandomArray() {
    let array = new Array(parseInt(Math.random() * 10 + 6)); //create and array with random length

    for (let i = 0; i < array.length; i++) {
        array[i] = parseInt(Math.random() * 100);
    }
    return array;
}

function SelectionSort(array) {
    let sortedArray = [...array];
    for (let i = 0; i < sortedArray.length; i++) {
        let minNumberIndex = i;
        for (let j = i + 1; j < sortedArray.length; j++) {
            if (sortedArray[j] < sortedArray[minNumberIndex]) {
                minNumberIndex = j;
            }
        }
        if (minNumberIndex != i) {
            var temp = sortedArray[i];
            sortedArray[i] = sortedArray[minNumberIndex];
            sortedArray[minNumberIndex] = temp;
        }
    }
    return sortedArray;
}

