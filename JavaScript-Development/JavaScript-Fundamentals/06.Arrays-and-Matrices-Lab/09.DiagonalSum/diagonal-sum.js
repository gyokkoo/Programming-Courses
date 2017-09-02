function diagonalSum (args) {
  let firstDiagonalSum = 0;
  let secondDiagonalSum = 0;

  for (let row = 0; row < args.length; row++) {
    firstDiagonalSum += args[row][row];
    secondDiagonalSum += args[row][args.length - row - 1];
  }

  console.log(firstDiagonalSum + ' ' + secondDiagonalSum);
}

diagonalSum([
  [20, 40],
  [10, 60]
])