function circleArea(args) {
    let r = Number(args[0]);
    let area = Math.PI * r * r;
    console.log(area);
    console.log(Math.round(area * 100) / 100);
}

circleArea(['5']);