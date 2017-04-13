function countOccurrences(arr) {
    let stringToCheck = arr[0];
    let letter = arr[1];

    let count = 0;
    for (let i = 0; i < stringToCheck.length; i++) {
        if (stringToCheck[i] == letter) {
            count++;
        }
    }

    return count;
}

console.log(countOccurrences(['hello', 'l']));