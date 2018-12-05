function decimalToBinary(decimal) {
  if (isNaN(decimal)) {
    console.error('the passed parameter is not a number');
    return;
  }
  let binary = '';
  let tempNumber = decimal;
  while (tempNumber > 0) {
    let rest = tempNumber % 2;
    binary = `${rest}${binary}`;
    tempNumber = (tempNumber - rest) / 2;
  }
  return binary;
}

let decimal = 93;
console.log(decimalToBinary(decimal));//way one
console.log(decimal.toString(2));//way two