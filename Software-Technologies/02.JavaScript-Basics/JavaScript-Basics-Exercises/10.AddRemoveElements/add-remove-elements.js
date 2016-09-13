function addRemoveElements(args) {
    let arr = [];

    for (let i = 0; i < args.length; i++) {
        let tokens = args[i].split(" ");
        let command = tokens[0];
        let num = Number(tokens[1]);
        if (command == "add") {
            arr.push(num);
        } else if (command == "remove") {
            if (0 <= num && num < arr.length) {
                arr.splice(num, 1);
            }
        }
    }

    arr = arr.filter(Number);

    for (let e of arr) {
        console.log(e);
    }
}

// addRemoveElements(['add 3', 'add 5', 'add 7']);
// addRemoveElements(['add 3', 'add 5', 'remove 1', 'add 2']);
addRemoveElements(['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']);