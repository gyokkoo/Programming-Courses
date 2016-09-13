function keyValuePairs(args) {
    let arr = [];

    for (let i = 0; i < args.length - 1; i++) {
        let tokens = args[i].split(" ");
        let key = tokens[0];
        let value = tokens[1];

        arr[key] = value;
    }

    let targetKey = args[args.length - 1];
    if (arr[targetKey] == undefined) {
        return "None";
    }

    return arr[targetKey];
}