function processOddNumbers (args) {
  let result = args
    .filter((num, i) => i % 2 === 1)
    .map(x => 2 * x)
    .reverse();

  console.log(result.join(' '));
}

processOddNumbers([10, 15, 20, 25]);