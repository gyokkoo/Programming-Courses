function dnaHelix(n) {
    let symbols = 'ATCGTTAGGG'.split('');
    let index = -1;
    for (let i = 1; i <= n; i++) {
        let string = '';
        if (i % 4 === 1) {
            string += `**${symbols[getIndex()]}${symbols[getIndex()]}**`;
        }
        if (i % 4 === 2) {
            string += `*${symbols[getIndex()]}--${symbols[getIndex()]}*`;
        }
        if (i % 4 === 3) {
            string += `${symbols[getIndex()]}----${symbols[getIndex()]}`;
        }
        if (i % 4 === 0) {
            string += `*${symbols[getIndex()]}--${symbols[getIndex()]}*`;
        }
        console.log(string);
    }

    function getIndex() {
        index++;
        if (index === symbols.length) {
            index = 0;
        }
        return index;
    }
}

dnaHelix(10);