let expect = require("chai").expect;
let isOddOrEven = require("../is-odd").isOddOrEven;

describe("isOddOrEven", function () {
    it("with a number parameter, should return undefined", function () {
        expect(isOddOrEven(25)).to.equal(undefined,
            "Function did not return the correct result");
    });

    it("with an object parameter, should return undefined", function () {
        expect(isOddOrEven({name: "Gosho"})).to.equal(undefined,
            "Function did not return the correct result");
    });

    it("with no parameter, should return undefined", function () {
        expect(isOddOrEven()).to.equal(undefined,
            "Function did not return the correct result");
    });

    it("with an even length string, should return correct result", function () {
        expect(isOddOrEven("abcd")).to.equal("even",
            "Function did not return the correct result");
    });

    it("with an odd length string, should return correct result", function () {
        expect(isOddOrEven("abcde")).to.equal("odd",
            "Function did not return the correct result");
    });

    it("with an empty string, should return correct result", function () {
        expect(isOddOrEven("")).to.equal("even",
            "Function did not return the correct result");
    });

    it("with multiple consecutive checks, should return correct values", function () {
        expect(isOddOrEven("cat")).to.equal("odd",
            "Function did not return the correct result");
        expect(isOddOrEven("elephant")).to.equal("even",
            "Function did not return the correct result");
        expect(isOddOrEven("is it even")).to.equal("even",
            "Function did not return the correct result");
    });
});