let expect = require("chai").expect;
let jsdom = require("jsdom-global")();
let sharedObject = require("../shared-objects").sharedObject;
let $ = require("jquery");

describe("sharedObject", function () {
    beforeEach("initalize", function () {
        document.body.innerHTML = `<div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`;
    });

    it("name property, should start as null", function () {
        expect(sharedObject.name).to.be.equal(null, "Name did not start with value null");
    });

    it("income property, should start as null", function () {
        expect(sharedObject.income).to.be.equal(null, "Income did not start with value null");
    });

    describe("changeName", function () {
        it("with invalid parameters, should not change name property", function () {
            sharedObject.changeName("");
            expect(sharedObject.name).to.be.equal(null, "Name changed incorrectly");
        });

        it("with invalid parameters and preexisting value, should not change name property", function () {
            sharedObject.name = "Pesho";
            sharedObject.changeName("");
            expect(sharedObject.name).to.be.equal("Pesho", "Name changed incorrectly");
        });

        it("with valid parameters and preexisting value, should change name property", function () {
            sharedObject.name = "Ivan";
            sharedObject.changeName("Stamat");
            expect(sharedObject.name).to.be.equal("Stamat", "Name changed incorrectly");
            expect(($('#name').val())).to.be.equal("Stamat", "Name changed incorrectly");
        });

        it("with invalid parameters and preexisting value, should not change name textbox", function () {
            let nameTextbox = $('#name');
            nameTextbox.val("Pesho");
            sharedObject.changeName("");
            expect(nameTextbox.val()).to.be.equal("Pesho", "Name changed incorrectly");
        });

        it("with valid name, should change name property", function () {
            sharedObject.changeName("George");
            expect(sharedObject.name).to.be.equal("George", "Name did not change");
        });

        it("with valid name, should change name textbox value", function () {
            sharedObject.changeName("Pesho");
            let nameTextbox = $('#name');
            expect(nameTextbox.val()).to.be.equal("Pesho", "Name did not change");
        });
    });

    describe("changeIncome", function () {
        it("with invalid parameters, should not change income property", function () {
            sharedObject.changeName("");
            expect(sharedObject.income).to.be.equal(null, "Name changed incorrectly");
        });

        it("with invalid parameters and preexisting value, should not change income property", function () {
            sharedObject.income = 50;
            sharedObject.changeName("");
            expect(sharedObject.income).to.be.equal(50, "Name changed incorrectly");
        });

        it("with invalid parameters and preexisting value, should not change income property", function () {
            sharedObject.income = 50;
            sharedObject.changeIncome({age: 18});
            expect(sharedObject.income).to.be.equal(50, "Income changed incorrectly");
        });

        it("with a floating point number, should not change income property", function () {
            sharedObject.income = 24;
            sharedObject.changeIncome(3.14);
            expect(sharedObject.income).to.be.equal(24, "Income changed incorrectly");
        });

        it("with a negative number, should not change income property", function () {
            sharedObject.income = 24;
            sharedObject.changeIncome(-150);
            expect(sharedObject.income).to.be.equal(24, "Income changed incorrectly");
        });

        it("with a zero, should not change income property", function () {
            sharedObject.income = 24;
            sharedObject.changeIncome(0);
            expect(sharedObject.income).to.be.equal(24, "Income changed incorrectly");
        });

        it("with invalid parameters should not change income textbox", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val('5');
            sharedObject.changeIncome({name: "pesho"});
            expect(incomeTextbox.val()).to.be.equal("5", "Income changed incorrectly");
        });

        it("with a floating point number, should not change income property", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val('5');
            sharedObject.changeIncome(3.14);
            expect(incomeTextbox.val()).to.be.equal("5", "Income changed incorrectly");
        });

        it("with a negative number, should not change income textbox value", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val('5');
            sharedObject.changeIncome(-3);
            expect(incomeTextbox.val()).to.be.equal("5", "Income changed incorrectly");
        });

        it("with NaN, should not change income textbox value", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val('5');
            sharedObject.changeIncome(NaN);
            expect(incomeTextbox.val()).to.be.equal("5", "Income changed incorrectly");
        });

        it("with a zero, should not change income textbox value", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val('5');
            sharedObject.changeIncome(0);
            expect(incomeTextbox.val()).to.be.equal("5", "Income changed incorrectly");
        });

        it("with valid integer, should change income textbox value", function () {
            sharedObject.changeIncome(45);
            let incomeTextbox = $('#income');
            expect(incomeTextbox.val()).to.be.equal("45", "Income did not change");
        });
    });

    describe('updateName', function () {
        it("with invalid parameter, should not change name property", function () {
            sharedObject.name = "test";
            let nameTextbox = $('#name');
            nameTextbox.val("");
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('test', "Name changed incorrectly");
        });

        it("with valid name, should change name property", function () {
            sharedObject.name = "test";
            let nameTextbox = $('#name');
            nameTextbox.val("George");
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('George', "Name changed incorrectly");
        });
    });

    describe('updateIncome', function () {
        it("with invalid parameter, should not change income property", function () {
            sharedObject.income = 55;
            let incomeTextbox = $('#income');
            incomeTextbox.val("asd");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(55, "Income changed incorrectly");
        });

        it("with a floating point number, should not change income property", function () {
            sharedObject.income = 55;
            let incomeTextbox = $('#income');
            incomeTextbox.val("23.14");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(55, "Income changed incorrectly");
        });

        it("with a negative number string, should not change income property", function () {
            sharedObject.income = 55;
            let incomeTextbox = $('#income');
            incomeTextbox.val("-5");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(55, "Income changed incorrectly");
        });

        it("with a empty string, should not change income property", function () {
            sharedObject.income = 55;
            let incomeTextbox = $('#income');
            incomeTextbox.val("");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(55, "Income changed incorrectly");
        });

        it("with a valid number, should change income property", function () {
            let incomeTextbox = $('#income');
            incomeTextbox.val("25");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(25, "Income did not change");
        });
    });
});