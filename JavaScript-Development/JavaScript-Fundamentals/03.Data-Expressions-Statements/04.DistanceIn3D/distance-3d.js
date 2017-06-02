function distanceIn3D(args) {
    let x1 = args[0];
    let y1 = args[1];
    let z1 = args[2];
    let x2 = args[3];
    let y2 = args[4];
    let z2 = args[5];

    let deltaX = Math.pow((x1 - x2), 2);
    let deltaY = Math.pow((y1 - y2), 2);
    let deltaZ = Math.pow((z1 - z2), 2);

    let distance = Math.sqrt(deltaX + deltaY + deltaZ);
    console.log(distance);
}

distanceIn3D([3.5, 0, 1, 0, 2, -1]);