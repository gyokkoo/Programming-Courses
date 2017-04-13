function getStringOfNumbers(arr) {
    let number = Number(arr[0]);
    let result = "";
    for (let i = 1; i <= number; i++) {
        result += i.toString();
    }

    console.log(result);
}

getStringOfNumbers(['11']);