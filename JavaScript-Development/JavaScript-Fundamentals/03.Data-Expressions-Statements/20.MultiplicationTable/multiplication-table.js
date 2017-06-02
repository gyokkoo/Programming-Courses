function multiplicationTable(n) {
    console.log('<table border="1">');

    let row = '<tr>'
    for (let i = 0; i <= n; i++) {
        if (i == 0) {
            row += '<th>x</th>';
        } else {
            row += `<th>${i}</th>`;
        }
    }
    row += '</tr>';
    console.log(row);

    for (let i = 1; i <= n; i++) {
        printRow(i);
    }
    console.log('</table>');

    function printRow(startNumber) {
        let row = '<tr>' + `<th>${startNumber}</th>`;
        for (let i = startNumber; i <= startNumber * n; i += startNumber) {
            row += `<td>${i}</td>`;
        }
        row += '</tr>';
        console.log(row);
    }
}

multiplicationTable(5);