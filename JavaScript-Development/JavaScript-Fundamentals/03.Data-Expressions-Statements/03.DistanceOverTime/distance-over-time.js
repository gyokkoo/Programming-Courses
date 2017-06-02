function distanceOverTime(args) {
    let speed1 = args[0];
    let speed2 = args[1];
    let time = args[2];

    let dist1 = speed1 * time / 3.6;
    let dist2 = speed2 * time / 3.6;

    let delta = Math.abs(dist1 - dist2);
    console.log(delta);
}

distanceOverTime([11, 10, 120]);