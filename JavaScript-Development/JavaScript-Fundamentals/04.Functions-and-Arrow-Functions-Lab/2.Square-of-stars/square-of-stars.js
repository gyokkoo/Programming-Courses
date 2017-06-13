function squareOfStars(n) {
    for (let i = 1; i <= n; i++) {
        print()
    }

    function print(count = n) {
        console.log('*' + ' *'.repeat(count - 1))
    }
}

squareOfStars(5);