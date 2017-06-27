function validityChecker(args) {
    let x1 = args[0];
    let y1 = args[1];
    let x2 = args[2];
    let y2 = args[3];

    checkValidity(x1, y1, 0, 0);
    checkValidity(x2, y2, 0, 0);
    checkValidity(x1, y1, x2, y2);

    function checkValidity(x1, y1, x2, y2) {
        let deltaX = Math.pow(x2 - x1, 2);
        let deltaY = Math.pow(y2 - y1, 2);
        if (Math.sqrt(deltaX + deltaY) % 1 === 0) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }
}

validityChecker([3, 0, 0, 4]);