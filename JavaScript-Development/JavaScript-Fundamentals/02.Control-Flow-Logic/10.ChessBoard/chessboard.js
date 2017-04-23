function chessboard(args) {
    let size = Number(args[0]);
    let html = '<div class="chessboard">\n';
    for (let row = 0; row < size; row++) {
        html += '  <div>\n';
        let color = (row % 2 == 0) ? 'black' : 'white';
        for (let col = 0; col < size; col++) {
            html += `    <span class="${color}"></span>\n`;
            color = (color == 'white') ? 'black' : 'white';
        }
        html += '  </div>\n';
    }
    return html + '</div>';
}

console.log(chessboard(['3']));