function oddEven(args) {
    let number = Number(args[0]);
    if (number < 0) {
        number = -number;
    }
    if (number % 2 == 0) {
        console.log('even');
    } else if (number % 2 == 1) {
        console.log('odd');
    } else {
        console.log('invalid');
    }
}
oddEven(['-5']);