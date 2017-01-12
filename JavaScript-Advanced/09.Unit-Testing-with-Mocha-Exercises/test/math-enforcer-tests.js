let expect = require("chai").expect;
let mathEnforcer = require("../math-enforcer").mathEnforcer;

describe("mathEnforcer", function () {
    describe("addFive", function () {
        it("with a non-number parameter, should return correct result", function () {
            expect(mathEnforcer.addFive("ABCD")).to.be.undefined;
        });

        it("with a no parameter, should return correct result", function () {
            expect(mathEnforcer.addFive()).to.be.undefined;
        });

        it("with a positive number, should return correct result", function () {
            expect(mathEnforcer.addFive(0)).to.be.equal(5);
            expect(mathEnforcer.addFive(5)).to.be.equal(10);
            expect(mathEnforcer.addFive(15)).to.be.equal(20);
        });

        it("with a negative number, should return correct result", function () {
            expect(mathEnforcer.addFive(-0)).to.be.equal(5);
            expect(mathEnforcer.addFive(-5)).to.be.equal(0);
            expect(mathEnforcer.addFive(-15)).to.be.equal(-10);
        });

        it("with a floating point number, should return correct result", function () {
            expect(mathEnforcer.addFive(3.14)).to.be.equal(3.14 + 5);
            expect(mathEnforcer.addFive(-3.14)).to.be.equal(-3.14 + 5);
        });

        it("with a floating point number, should return correct result", function () {
            expect(mathEnforcer.addFive(3.14)).to.be.closeTo(7, 8);
            expect(mathEnforcer.addFive(5.01)).to.be.closeTo(5, 6);
        });
    });

    describe("subtractTen", function () {
        it("with a non-number parameter, should return correct result", function () {
            expect(mathEnforcer.subtractTen("ABCD")).to.be.undefined;
        });

        it("with a no parameter, should return correct result", function () {
            expect(mathEnforcer.subtractTen()).to.be.undefined;
        });

        it("with a positive numbers, should return correct result", function () {
            expect(mathEnforcer.subtractTen(0)).to.be.equal(-10);
            expect(mathEnforcer.subtractTen(5)).to.be.equal(-5);
            expect(mathEnforcer.subtractTen(15)).to.be.equal(5);
        });

        it("with a negative numbers, should return correct result", function () {
            expect(mathEnforcer.subtractTen(-0)).to.be.equal(-10);
            expect(mathEnforcer.subtractTen(-5)).to.be.equal(-15);
            expect(mathEnforcer.subtractTen(-15)).to.be.equal(-25);
        });

        it("with a floating point numbers, should return correct result", function () {
            expect(mathEnforcer.subtractTen(3.14)).to.be.equal(3.14 - 10);
            expect(mathEnforcer.subtractTen(-3.14)).to.be.equal(-3.14 - 10);
        });

        it("with a floating point number, should return correct result", function () {
            expect(mathEnforcer.subtractTen(11.14)).to.be.closeTo(1, 2);
            expect(mathEnforcer.subtractTen(15.01)).to.be.closeTo(15, 16);
        });
    });

    describe("sum", function () {
        it("with a non-number parameter, should return correct result", function () {
            expect(mathEnforcer.sum("number1", "number2")).to.be.undefined;
        });

        it("with first non-number parameter, should return correct result", function () {
            expect(mathEnforcer.sum("number1", 4)).to.be.undefined;
        });

        it("with second non-number parameter, should return correct result", function () {
            expect(mathEnforcer.sum(4, "number")).to.be.undefined;
        });

        it("with a no parameter, should return correct result", function () {
            expect(mathEnforcer.sum()).to.be.undefined;
        });

        it("with a positive numbers, should return correct result", function () {
            expect(mathEnforcer.sum(0, 0)).to.be.equal(0);
            expect(mathEnforcer.sum(2, 5)).to.be.equal(7);
            expect(mathEnforcer.sum(255, 300)).to.be.equal(555);
        });

        it("with a negative number, should return correct result", function () {
            expect(mathEnforcer.sum(-0, -0)).to.be.equal(0);
            expect(mathEnforcer.sum(-5, -7)).to.be.equal(-12);
            expect(mathEnforcer.sum(-15, -10)).to.be.equal(-25);
        });

        it("with a floating point number, should return correct result", function () {
            expect(mathEnforcer.sum(3.14, 4.14)).to.be.equal(3.14 + 4.14);
            expect(mathEnforcer.sum(-3.14, -9.99)).to.be.equal(-3.14 - 9.99);
        });

        it("with a floating point number, should return correct result", function () {
            expect(mathEnforcer.sum(3.14, 14.14)).to.be.closeTo(17, 16);
            expect(mathEnforcer.sum(0.01, 0.01)).to.be.closeTo(0, 1);
        });
    });
});