function sumFirstLast(args) {
  let firstNumber = Number(args[0]);
  let lastNumber = Number(args[args.length - 1]);

  return firstNumber + lastNumber;
}

console.log(sumFirstLast(['20', '30', '40']));