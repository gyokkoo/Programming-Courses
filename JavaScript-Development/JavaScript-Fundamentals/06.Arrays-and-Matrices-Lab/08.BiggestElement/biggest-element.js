function biggestElement (args) {
  let biggestElement =
    args
      .join()
      .split(',')
      .sort((a, b) => b - a)[0];

  return biggestElement;
}

console.log(biggestElement(
  [[20, 50, 10],
    [8, 33, 145]]));