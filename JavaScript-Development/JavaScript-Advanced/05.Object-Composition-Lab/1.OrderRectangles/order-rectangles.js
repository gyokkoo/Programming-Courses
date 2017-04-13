function orderRects(rectsData) {
    function createRect(width, height) {
        let rect = {
            width: width,
            height: height,
            area: () => rect.width * rect.height,
            compareTo: function (other) {
                let result = other.area() - rect.area();
                return result || (other.width - rect.width);
            },
            toString: function () {
                return `[${rect.width}, ${rect.height}]`;
            }
        };

        return rect;
    }

    let rects = [];
    for (let [width, height] of rectsData) {
        let rect = createRect(width, height);
        rects.push(rect);
    }
    rects.sort((a, b) => a.compareTo(b));
    return rects;
}

console.log(orderRects([[3, 4], [5, 3], [3, 4], [3, 5], [12, 1]]).join(", "));