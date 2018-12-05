let array = [1, 3, 5, 8, 8, 13, 20];//array with some test values
let key1 = 8, key2 = 12;  //some test keys

findKeyIndexes(array, key1);//existing key

findKeyIndexes(array, key2);//missing key

function findKeyIndexes(array, key) {// user-friendly result messages
  let keyIndexes = linearSearch(array, key);
  if (keyIndexes.length) {// equals to array.length > 0 expression
    console.log(`indexes of key "${key}" are:`);
    console.log(keyIndexes);
  } else {
    console.log(`key ${key} not found !`);
  }
  return keyIndexes;
}

function linearSearch(array, key) {//modified linear search that collects all indexes of the key criteria
  let keyIndexes = [];
  for (let index = 0; index < array.length; index++) {
    if (array[index] === key) {
      keyIndexes.push(index);
    }
  }
  return keyIndexes;
}