function turnObjectIntoJson(args) {
    let obj = {};
    for (let i = 0; i < args.length; i++) {
        let tokens = args[i].split(" -> ");
        let key = tokens[0];
        let value = tokens[1];

        if (key == "grade") {
            obj[key] = Math.round(parseInt(value));
        } else if (key == "age") {
            obj[key] = Math.round(parseInt(value));
        } else {
            obj[key] = value;
        }
    }

    console.log(JSON.stringify(obj));
}

turnObjectIntoJson(['name -> Angel']);