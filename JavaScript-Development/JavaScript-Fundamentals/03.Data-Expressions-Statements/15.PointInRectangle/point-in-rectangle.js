function pointInRectangle(args) {
    let [x, y, xMin, xMax, yMin, yMax] = args;

    let isXInside = xMin <= x && x <= xMax;
    let isYInside = yMin <= y && y <= yMax;

    if (isXInside && isYInside) {
        console.log('inside');
    } else {
        console.log('outside');
    }
}

pointInRectangle([8, -1, 2, 12, -3, 3]);