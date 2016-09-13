function setValues(args) {
    let n = Number(args[0]);
    let arr = [];
    for (let i = 0; i < n; i++) {
        arr[i] = 0;
    }

    for (let i = 1; i < args.length; i++) {
        let tokens = args[i].split(" - ");
        let index = Number(tokens[0]);
        let value = Number(tokens[1]);

        arr[index] = value;
    }

    for (let e of arr) {
        console.log(e);
    }
}

//setValues(['3', '0 - 5', '1 - 6', '2 - 7']);
setValues(['2', '0 - 5', '0 - 6', '0 - 7']);