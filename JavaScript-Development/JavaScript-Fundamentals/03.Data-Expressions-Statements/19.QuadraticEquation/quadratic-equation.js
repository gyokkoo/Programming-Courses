function quadraticEquation(a, b, c) {
    let discriminant = b * b - 4 * a * c;
    if (discriminant > 0) {
        let x1 = (-b - Math.sqrt(discriminant)) / (2 * a);
        let x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
        console.log(parseFloat(x1.toFixed(5)));
        console.log(parseFloat(x2.toFixed(5)));
    } else if (discriminant == 0) {
        let x = (-b) / (2 * a);
        console.log(parseFloat(x.toFixed(5)));
    } else if (discriminant < 0) {
        console.log('No');
    }
}

quadraticEquation([6, 11, -35]);