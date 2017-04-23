function cone(args) {
    let radius = Number(args[0]);
    let height = Number(args[1]);
    let s = Math.sqrt(radius * radius + height * height);

    let volume = Math.PI * radius * radius * height / 3;
    console.log("volume = " + volume);

    let area = Math.PI * radius * (radius + s);
    console.log("area = " + area);
}

cone(['3', '5']);
