function functionalCalculator(a, b, op) {

    let calculate = function (a, b, op) {
        return op(a, b)
    };

    let add = function (a, b) {
        return a + b;
    };

    let subtract = function (a, b) {
        return a - b;
    };

    let multiply = function (a, b) {
        return a * b;
    };

    let divide = function (a, b) {
        return a / b
    };

    switch (op) {
        case '+':
            return calculate(a, b, add);
        case '-':
            return calculate(a, b, subtract);
        case '*':
            return calculate(a, b, multiply);
        case '/':
            return calculate(a, b, divide);
    }
}

console.log(functionalCalculator(13, 6, '*'));