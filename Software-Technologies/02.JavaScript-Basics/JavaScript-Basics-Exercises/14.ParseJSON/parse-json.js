function parseJson(args) {
    for (let i = 0; i < args.length; i++) {
        let str = args[i];
        let obj = JSON.parse(str);
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Date: ${obj.date}`);
    }
}

parseJson([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}']);