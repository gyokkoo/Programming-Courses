function tripLength(args) {

    let x1 = args[0];
    let y1 = args[1];
    let x2 = args[2];
    let y2 = args[3];
    let x3 = args[4];
    let y3 = args[5];

    let distance123 = getDistance(x1, y1, x2, y2) + getDistance(x2, y2, x3, y3);
    let distance132 = getDistance(x1, y1, x3, y3) + getDistance(x3, y3, x2, y2);
    let distance213 = getDistance(x2, y2, x1, y1) + getDistance(x1, y1, x3, y3);

    let shortest = Math.min(distance123, distance132, distance213);
    if (shortest === distance123) {
        console.log(`1->2->3: ${shortest}`);
    } else if (shortest === distance132) {
        console.log(`1->3->2: ${shortest}`);
    } else if (shortest === distance213) {
        console.log(`2->1->3: ${shortest}`);
    }

    function getDistance(x1, y1, x2, y2) {
        let deltaX = x2 - x1;
        let deltaY = y2 - y1;
        return Math.sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

tripLength([5, 1, 1, 1, 5, 4]);