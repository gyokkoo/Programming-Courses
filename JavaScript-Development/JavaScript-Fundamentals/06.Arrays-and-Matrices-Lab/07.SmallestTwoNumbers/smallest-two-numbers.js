function smallestTwoNumbers (args) {
  let smallestTwoNumbers = args.sort((a, b) => a - b).slice(0, 2);
  console.log(smallestTwoNumbers.join(' '));
}

smallestTwoNumbers([30, 15, 50, 5]);