function bubbleSort(array) {
  const tempArray = [...array];
  const k = tempArray.length - 1;
  for (let i = 0; i < k; i++) {
    let swapped = false;
    for (let j = 0; j < k - i; j++) {
      if (tempArray[j] > tempArray[j + 1]) {
        const temp = tempArray[j];

        tempArray[j] = tempArray[j + 1];
        tempArray[j + 1] = temp;
        swapped = true;
      }
    }
    if (!swapped) { break; }
  }
  return tempArray;
}

var array = [51, 2, 62, 19, 1, 5, 7];
console.log(bubbleSort(array));