let expect = require("chai").expect;
let rgbToHexColor = require("../rgb-to-hex").rgbToHexColor;

describe("Test rgbToHexColor(red, green, blue)", function () {
   describe("Nominal cases (valid input)", function () {
       it("should return #FF9EAA on (255, 158, 170)", function () {
           let hex = rgbToHexColor(255, 158, 170);
           expect(hex).to.be.equal('#FF9EAA');
       });

       it("should return #FFFFFF on (255, 255, 255)", function () {
           let hex = rgbToHexColor(255, 255, 255);
           expect(hex).to.be.equal('#FFFFFF');
       });

       it("should return #000000 on (0, 0, 0)", function () {
           let hex = rgbToHexColor(0, 0, 0);
           expect(hex).to.be.equal('#000000');
       });

       it("should return #0A0B0C on (10, 11, 12)", function () {
           let hex = rgbToHexColor(10, 11, 12);
           expect(hex).to.be.equal('#0A0B0C');
       });

       it("should return #0D0E0F on (13, 14, 15)", function () {
           let hex = rgbToHexColor(13, 14, 15);
           expect(hex).to.be.equal('#0D0E0F');
       });
   });

   describe("Speacial cases (invalid input)", function () {
       it("should return undefined on (-1, 200, 230)", function () {
           let hex = rgbToHexColor(-1, 200, 230);
           expect(hex).to.be.undefined;
       });

       it("should return undefined on (256, 256, 256)", function () {
           let hex = rgbToHexColor(256, 256, 256);
           expect(hex).to.be.undefined;
       });

       it("should return undefined on ('13', '14', '15')", function () {
           let hex = rgbToHexColor('13', '14', '15');
           expect(hex).to.be.undefined;
       });

       it("should return undefined on (150, 'str2', 'str3')", function () {
           let hex = rgbToHexColor(150, 'str2', 'str3');
           expect(hex).to.be.undefined;
       });

       it("should return undefined on ()", function () {
           let hex = rgbToHexColor();
           expect(hex).to.be.undefined;
       });

       it("should return undefined on (230)", function () {
           let hex = rgbToHexColor(230);
           expect(hex).to.be.undefined;
       });

       it("should return undefined on (230, 15)", function () {
           let hex = rgbToHexColor(230, 15);
           expect(hex).to.be.undefined;
       });
   });
});