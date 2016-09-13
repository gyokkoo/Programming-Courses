function productOfThreeNumbers(arr) {
    let x = Number(arr[0]);
    let y = Number(arr[1]);
    let z = Number(arr[2]);

    if (x == 0 || y == 0 || z == 0) {
        return "Positive";
    } else if (countOfNegativeNumbers() % 2 == 1) {
        return "Negative";
    }

    return "Positive";

    function countOfNegativeNumbers() {
        let count = 0;
        if (x < 0)
            count++;
        if (y < 0)
            count++;
        if (z < 0)
            count++;

        return count;
    }
}

console.log(productOfThreeNumbers(['2', '3', '-1']));
console.log(productOfThreeNumbers(['5', '4', '3']));
console.log(productOfThreeNumbers(['-3', '-4', '5']));