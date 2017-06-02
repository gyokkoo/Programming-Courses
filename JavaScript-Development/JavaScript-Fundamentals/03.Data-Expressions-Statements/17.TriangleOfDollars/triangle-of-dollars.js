function trianglesOfDollars(n) {
    const symbol = '$';
    for (let i = 0; i < n; i++) {
        let row = symbol;
        for (let j = 0; j < i; j++) {
            row += symbol;
        }
        console.log(row);
    }
}

trianglesOfDollars(4);