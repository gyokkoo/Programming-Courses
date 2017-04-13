function isOddOrEven(str) {
    if (typeof(str) != 'string') {
        return undefined;
    }

    if (str.length % 2 == 0) {
        return "even";
    }

    return "odd";
}

module.exports = {isOddOrEven};