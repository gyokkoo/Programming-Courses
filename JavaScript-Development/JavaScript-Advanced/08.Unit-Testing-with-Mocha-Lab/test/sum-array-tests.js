let expect = require("chai").expect;
let sum = require("../sum-array").sum;

describe("Test sum(arr)", function () {
    it("should return 6 for [1, 2, 3]", function () {
        let expectedSum = 6;
        let actualSum = sum([1, 2, 3]);
        expect(actualSum).to.be.equal(expectedSum);
    });

    it("should return 3 for [-1, 2, -3, 4, -5, 6]", function () {
        let expectedSum = 3;
        let actualSum = sum([-1, 2, -3, 4, -5, 6]);
        expect(actualSum).to.be.equal(expectedSum);
    });

    it("should return 4 for [4]", function () {
        let expectedSum = 4;
        let actualSum = sum([4]);
        expect(actualSum).to.be.equal(expectedSum);
    });

    it("should return 0 for [-5, 5]", function () {
        let expectedSum = 0;
        let actualSum = sum([-5, 5]);
        expect(actualSum).to.be.equal(expectedSum);
    });

    it("should return 0 for []", function () {
        let expectedSum = 0;
        let actualSum = sum([]);
        expect(actualSum).to.be.equal(expectedSum);
    });

    it("should return 1 for ['1', '2', '-2']", function () {
        let expectedSum = 1;
        let actualSum = sum(['1', '2', '-2']);
        expect(actualSum).to.be.equal(expectedSum);
    });


    it("should return NaN for ['str']", function () {
        let actualSum = sum(['str']);
        expect(actualSum).to.be.NaN;
    });
});