function calculateFibonacci(n) {
    let fibonacci = (() => {
        let fib1 = 0;
        let fib2 = 1;
        return () => {
            let oldFib1 = fib1;
            let oldFib2 = fib2;
            fib1 = oldFib2;
            fib2 = oldFib1 + oldFib2;
            return oldFib2;
        }
    })();

    let fibNumbers = [];
    for (let i = 1; i <= n; i++) {
        fibNumbers.push(fibonacci());
    }
    return fibNumbers;
}

console.log(calculateFibonacci(5));