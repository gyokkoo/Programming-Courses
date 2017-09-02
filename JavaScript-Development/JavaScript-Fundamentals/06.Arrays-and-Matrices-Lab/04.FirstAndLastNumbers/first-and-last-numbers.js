function firstAndLastNumbers (args) {
  let k = args[0];
  console.log(args.slice(1, k + 1).join(' '));
  console.log(args.slice(args.length - k, args.length).join(' '));
}

firstAndLastNumbers([2, 7, 8, 9]);