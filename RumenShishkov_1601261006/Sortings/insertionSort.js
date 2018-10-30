function instertionSort(array) {
  const tempArray = [...array];

  for (let i = 0; i < tempArray.length; i++) {
    const currentElement = tempArray[i];
    for (var j = i - 1; j > -1 && tempArray[j] > currentElement; j--) {
      tempArray[j + 1] = tempArray[j];
    }
    tempArray[j + 1] = currentElement;
  }
  return tempArray;
}

var array = [7, 19, 4, 25, 81, 3];
console.log(instertionSort(array));