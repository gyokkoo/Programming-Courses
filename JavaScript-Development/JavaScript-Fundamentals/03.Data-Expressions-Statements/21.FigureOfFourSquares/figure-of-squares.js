function figureOfSquares(n) {
    let length = n % 2 == 0 ? n - 1 : n;
    for (let i = 1; i <= length; i++) {
        if (i == 1 || (length + 1) / i == 2 || i == length) {
            console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
        } else {
            console.log('|' + ' '.repeat(n - 2) + '|' + ' '.repeat(n - 2) + '|');
        }
    }
}

figureOfSquares(2);