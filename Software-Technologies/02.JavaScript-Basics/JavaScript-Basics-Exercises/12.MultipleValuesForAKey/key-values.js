function keyValues(args) {
    let arr = [];
    let targetKey = args[args.length - 1];
    let found = false;

    for (let i = 0; i < args.length - 1; i++) {
        let tokens = args[i].split(" ");
        let key = tokens[0];
        let value = tokens[1];

        arr[key] = value;
        if (targetKey == key) {
            console.log(arr[key]);
            found = true;
        }

        arr.key = value;
    }

    if (!found) {
        console.log("None");
    }
}

keyValues(['key value', 'key eluav', 'test tset', 'key']);