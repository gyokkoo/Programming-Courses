function triangleOfStars(n) {
    const character = '*';
    for (let i = 1; i <= n; i++) {
        console.log(character.repeat(i));
    }
    for (let i = n - 1; i >= 0; i--) {
        console.log(character.repeat(i));
    }
}

triangleOfStars(5);