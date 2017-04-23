function binaryLogarithm(args) {
    let nums = args.map(Number);
    for (let num of nums) {
        console.log(Math.log2(num));
    }
}

binaryLogarithm(['1024']);