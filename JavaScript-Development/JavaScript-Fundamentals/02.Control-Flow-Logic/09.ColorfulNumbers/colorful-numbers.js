function colorfulNumber(args) {
    let n = Number(args[0]);
    let html = '<ul>\n';
    for (let i = 1; i <= n; i++) {
        let color = 'green';
        if (i % 2 == 0) {
            color = 'blue';
        }

        html += `   <li><span style='color: ${color}'>${i}</span></li>\n`;
    }
    html += '</ul>';

    return html;
}

console.log(colorfulNumber(['10']));