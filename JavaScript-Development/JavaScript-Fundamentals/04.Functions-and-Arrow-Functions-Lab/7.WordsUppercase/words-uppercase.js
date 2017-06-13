function wordsUppercase(str) {
    let words = str.toUpperCase().split(/\W+/);
    words = words.filter(w => w !== '');
    return words.join(', ');
}

console.log(wordsUppercase('Hello'));