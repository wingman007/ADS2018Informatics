function binaryToDecimal(binary) {
  let decNumber = 0;
  let pow = binary.length - 1;
  for (let i = pow; i >= 0; i--) {
    if (binary[i] == 1) {
      decNumber += Math.pow(2, pow - i);
    }
  }
  return decNumber;
}

var binary = "01011101";
console.log(binaryToDecimal(binary));//way one
console.log(parseInt(0b01011101, 10));//way two
