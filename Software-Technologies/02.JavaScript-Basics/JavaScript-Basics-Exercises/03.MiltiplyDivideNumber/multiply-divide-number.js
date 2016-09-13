function multiplyDivideNumber(arr) {
    let n = Number(arr[0]);
    let x = Number(arr[1]);

    if (x >= n) {
        return n * x;
    } else if (x < n) {
        return n / x;
    }
}

console.log(multiplyDivideNumber(['2', '3']));
console.log(multiplyDivideNumber(['13', '13']));
console.log(multiplyDivideNumber(['3', '2']));
console.log(multiplyDivideNumber(['144', '12']));