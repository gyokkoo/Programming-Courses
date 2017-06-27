function findTreasures(args) {
    let checkTuvalu = (x, y) => (1 <= x && x <= 3) && (1 <= y && y <= 3);

    let checkTokelau = (x, y) => (8 <= x && x <= 9) && (0 <= y && y <= 1);

    let checkSamoa = (x, y) => (5 <= x && x <= 7) && (3 <= y && y <= 6);

    let checkTonga = (x, y) => (0 <= x && x <= 2) && (6 <= y && y <= 8);

    let checkCook = (x, y) => (4 <= x && x <= 9) && (7 <= y && y <= 8);

    for (let i = 0; i < args.length; i += 2) {
        let x = args[i];
        let y = args[i + 1];
        if(checkTuvalu(x, y)) {
            console.log('Tuvalu');
        } else if (checkTokelau(x, y)) {
            console.log('Tokelau');
        } else if (checkSamoa(x, y)) {
            console.log('Samoa');
        } else if (checkTonga(x, y)) {
            console.log('Tonga');
        } else if (checkCook(x, y)) {
            console.log('Cook');
        } else {
            console.log('On the bottom of the ocean');
        }
    }
}

findTreasures([4, 2, 1.5, 6.5, 1, 3]);