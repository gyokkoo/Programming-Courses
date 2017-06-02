function gradsToDegrees(grads) {
    let degrees = (grads * 360) / 400;
    degrees %= 360;

    if (degrees < 0) {
        degrees += 360;
    }

    console.log(degrees);
}

gradsToDegrees(850);