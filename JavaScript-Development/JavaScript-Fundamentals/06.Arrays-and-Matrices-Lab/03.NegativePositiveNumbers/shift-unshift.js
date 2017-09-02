function shiftUnshift (args) {
  let result = [];
  for (let number of args) {
    if (number < 0) {
      result.unshift(number);
    } else {
      result.push(number);
    }
  }

  console.log(result.join('\n'));
}

shiftUnshift([7, -2, 8, 9]);