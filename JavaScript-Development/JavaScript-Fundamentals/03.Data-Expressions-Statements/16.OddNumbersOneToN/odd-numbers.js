function oddNumbers(n) {
    for (let i = 1; i <= n; i++) {
        if (i % 2 == 1) {
            console.log(i);
        }
    }
}

oddNumbers(7);