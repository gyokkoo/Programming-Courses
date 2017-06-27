function cookingByNumber(args) {
    let number = Number(args[0]);

    for (let i = 1; i < args.length; i++) {
        let operationName = args[i];
        number = getResult(number, operationName)
        console.log(number)
    }

    function getResult(number, operationName) {
        switch (operationName) {
            case 'chop':
                return number / 2;
            case 'dice':
                return Math.sqrt(number);
            case 'spice':
                return number + 1;
            case 'bake':
                return number * 3;
            case 'fillet':
                return number * 0.8;
        }
    }
}

cookingByNumber([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);