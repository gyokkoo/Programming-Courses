function insideVolume (args) {
    for (let i = 0; i < args.length; i += 3) {
        let x = Number(args[i]);
        let y = Number(args[i + 1]);
        let z = Number(args[i + 2]);

        if (isInside(x, y, z)) {
            console.log('inside')
        } else {
            console.log('outside')
        }
    }

    function isInside(x, y, z) {
        let x1 = 10;
        let x2 = 50;
        let y1 = 20;
        let y2 = 80;
        let z1 = 15;
        let z2 = 50;
        if (x1 <= x && x <= x2) {
            if (y1 <= y && y <= y2) {
                if (z1 <= z && z <= z2) {
                    return true;
                }
            }
        }
        return false;
    }
}

insideVolume([13.1, 50, 31.5,
    50, 80, 50,
    -5, 18, 43]
);