function calcSums(arr) {
    let objects = arr.map(JSON.parse);
    let sums = {};
    for (let obj of objects) {
        sums[obj.town] = sums[obj.town] || 0;
        sums[obj.town] += obj.income;

        // if (obj.town in sums)
        //     sum[obj.town] += obj.income;
        // else
        //     sum[obj.town] = obj.income;
    }
    let towns = Object.keys(sums);
    towns.sort();
    for (let t of towns) {
        console.log(`${t} -> ${sums[t]}`);
    }
}

calcSums([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Varna","income":70}',
]);