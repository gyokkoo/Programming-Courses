function compoundInterest(args) {
    let principalSum = args[0];
    let interestRate = args[1];
    let compoundingPeriod = args[2];
    let timespan = args[3];

    let n = 12 / compoundingPeriod;
    let compoundInterest = principalSum * Math.pow((1 + interestRate / (100 * n)), n * timespan);
    console.log(compoundInterest.toFixed(2));
}

compoundInterest([1500, 4.3, 3, 6]);