function lookupChar(str, index) {
    if (typeof(str) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }

    if (index < 0 || str.length <= index) {
        return "Incorrect index";
    }

    return str.charAt(index);
}

module.exports = {lookupChar};