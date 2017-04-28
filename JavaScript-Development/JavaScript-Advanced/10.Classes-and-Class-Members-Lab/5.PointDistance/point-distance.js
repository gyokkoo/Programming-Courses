class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(p1, p2) {
        const deltaX = p1.x - p2.x;
        const deltaY = p1.y - p2.y;
        return Math.sqrt((deltaX * deltaX) + (deltaY * deltaY));
    }
}

let p1 = new Point(5, 5);
let p2 = new Point(9, 8);
console.log(Point.distance(p1, p2));
