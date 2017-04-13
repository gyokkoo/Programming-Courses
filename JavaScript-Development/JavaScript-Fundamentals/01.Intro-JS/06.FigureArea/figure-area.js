function figureArea(arr) {
    let w = Number(arr[0]);
    let h = Number(arr[1]);
    let W = Number(arr[2]);
    let H = Number(arr[3]);
    let matchW = Math.min(w, W);
    let matchH = Math.min(h, H);

    let area = h * w + H * W - matchW * matchH;
    console.log(area);

}

figureArea(['13', '2', '5', '8']);