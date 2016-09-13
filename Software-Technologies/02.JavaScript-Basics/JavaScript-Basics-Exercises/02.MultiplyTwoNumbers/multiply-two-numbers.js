function multiplyTwoNumbers(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);

    return num1 * num2;
}

console.log(multiplyTwoNumbers(['2', '3']));
console.log(multiplyTwoNumbers(['13', '13']));
console.log(multiplyTwoNumbers(['1', '2']));
console.log(multiplyTwoNumbers(['0', '50']));