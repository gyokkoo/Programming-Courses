function sum(arr) {
    let sum = 0;
    for (let i = 0; i < arr.length; i++) {
        sum += Number(arr[i]);
    }

    console.log("sum = " + sum);
    console.log("VAT = " + sum * 0.2);
    console.log("total = " + sum * 1.2);
}

sum(['3.12', '5', '18', '19.24', '1953.2262', '0.001564', '1.1445']);