function modifyAverage(number) {

    let addNine = number => number + '9';

    while (getNumberAverage(number) <= 5) {
        number = addNine(number)
    }
    console.log(number);

    function getNumberAverage(num) {
        let numberString = num.toString();
        let sum = 0;
        for (let i = 0; i < numberString.length; i++) {
            sum += Number(numberString[i])
        }
        return sum / numberString.length;
    }
}

modifyAverage(101);