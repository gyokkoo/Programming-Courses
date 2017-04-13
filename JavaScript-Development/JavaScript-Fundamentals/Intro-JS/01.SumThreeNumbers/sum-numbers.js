function sumNumbers(arr) {
    let first = Number(arr[0]);
    let second = Number(arr[1]);
    let third = Number(arr[2]);

    let sum = first + second + third;
    return sum;
}

console.log(sumNumbers(['2', '3', '4']));