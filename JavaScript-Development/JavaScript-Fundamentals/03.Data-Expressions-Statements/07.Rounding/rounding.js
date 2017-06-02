function rounding(args) {
    let number = args[0];
    let precision = args[1];

    if (precision > 15) {
        precision = 15;
    }

    console.log(parseFloat(number.toFixed(precision)));
}

rounding([3.1, 3]);