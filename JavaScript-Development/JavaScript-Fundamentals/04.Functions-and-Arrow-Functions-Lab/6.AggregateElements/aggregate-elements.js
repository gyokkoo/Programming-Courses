function aggregateElements(elements) {
    aggregate(elements, 0, (a, b) => a + b);
    aggregate(elements, 0, (a, b) => a + 1 / b);
    aggregate(elements, '', (a, b) => a + b);

    function aggregate(arr, initVal, func) {
        let value = initVal;
        for (let i = 0; i < arr.length; i++) {
            value = func(value, arr[i]);
        }

        console.log(value);
    }
}

aggregateElements([10, 20, 30]);