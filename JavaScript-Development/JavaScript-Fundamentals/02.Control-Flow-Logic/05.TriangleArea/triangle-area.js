function triangleArea(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = Number(args[2]);
    let p = (a + b + c) / 2;
    let area = Math.sqrt(p * (p - a) * (p - b) * (p - c));
    console.log(area);
}

triangleArea([2, 3.5, 4]);