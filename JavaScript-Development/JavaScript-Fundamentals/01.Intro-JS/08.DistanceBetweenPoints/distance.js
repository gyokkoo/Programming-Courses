function distanceBetweenPoints(arr) {
    let pointA = {x1: Number(arr[0]), y1: Number(arr[1])};
    let pointB = {x2: Number(arr[2]), y2: Number(arr[3])};

    let distance = Math.sqrt(Math.pow(pointA.x1 - pointB.x2, 2) + Math.pow(pointA.y1 - pointB.y2, 2));
    console.log(distance);
}

distanceBetweenPoints(['2.34', '15.66', '-13.55', '-2.9985']);