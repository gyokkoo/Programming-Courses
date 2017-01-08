let expect = require("chai").expect;
let isSymmetric = require("../check-for-symmetry").isSymmetric;

describe("Test isSymmetric(arr)", function () {
    it("should return true for [1, 2, 1]", function () {
        let expectedResult = true;
        let actualResult = isSymmetric([1, 2, 1]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for [1, 5, 7, 8, 9, 7, 5, 1]", function () {
        let expectedResult = false;
        let actualResult = isSymmetric([1, 5, 7, 8, 9, 7, 5, 1]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for [-1, 5, 3, 3, 5, -1]", function () {
        let expectedResult = true;
        let actualResult = isSymmetric([-1, 5, 3, 3, 5, -1]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for ['Ivan', 'Pesho', 'Ivan']", function () {
        let expectedResult = true;
        let actualResult = isSymmetric(['Ivan', 'Pesho', 'Ivan']);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for ['1', '2']", function () {
        let expectedResult = false;
        let actualResult = isSymmetric(['1', '2']);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for []", function () {
        let expectedResult = true;
        let actualResult = isSymmetric([]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for [1]", function () {
        let expectedResult = true;
        let actualResult = isSymmetric([1]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for 1, 2, 2, 1", function () {
        let expectedResult = false;
        let actualResult = isSymmetric(1, 2, 2, 1);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for ['str1', 'str2']", function () {
        let expectedResult = false;
        let actualResult = isSymmetric(['str1', 'str2']);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for [5,'hi',{a:5},new Date(),{X:5},'hi',5] ", function () {
        let expectedResult = true;
        let actualResult = isSymmetric([5, 'hi', {a: 5}, new Date(), {a: 5}, 'hi', 5]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for [5,'hi',{a:5},new Date(),{a:5},'hi',5] ", function () {
        let expectedResult = false;
        let actualResult = isSymmetric([5, 'hi', {a: 5}, new Date(), {X: 5}, 'hi', 5]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return true for '-5, ,-5'", function () {
        let expectedResult = true;
        let actualResult = isSymmetric(["-5, ,-5"]);
        expect(actualResult).to.be.equal(expectedResult);
    });

    it("should return false for NaN", function () {
        let expectedResult = false;
        let actualResult = isSymmetric(NaN);
        expect(actualResult).to.be.equal(expectedResult);
    });
});