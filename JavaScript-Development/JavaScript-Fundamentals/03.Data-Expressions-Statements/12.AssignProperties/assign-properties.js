function assignProperties(args) {
    let obj = {};
    for (let i = 0; i < args.length; i += 2) {
        let key = args[i];
        let value = args[i + 1]
        obj[key] = value;
    }

    console.log(obj);
}

assignProperties(['name', 'Pesho', 'age', '23', 'gender', 'male']);