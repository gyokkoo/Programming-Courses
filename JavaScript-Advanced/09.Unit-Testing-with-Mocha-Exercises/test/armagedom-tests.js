let expect = require("chai").expect;
let jsdom = require("jsdom-global")();
let nuke = require("../armagedom").nuke;
$ = require("jquery");

describe("nuke", function () {
    beforeEach("initalize", function () {
        document.body.innerHTML = `<div id="target">
            <div class="nested target">
                <p>This is some text</p>
            </div>
            <div class="target">
                <p>Empty div</p>
            </div>
            <div class="inside">
                <span class="nested">Some more text</span>
                <span class="target">Some more text</span>
            </div>
            </div>`;
    });

    it('Same selectors, should do nothing', function () {
        let oldBody = $('body').html();
        nuke('.inside', '.inside');
        expect($('body').html()).to.be.equal(oldBody)
    });

    it('Omitted second parameter, should do nothing', function () {
        let oldBody = $('body').html();
        nuke('.inside');
        expect($('body').html()).to.be.equal(oldBody)
    });

    it('Invalid selector, should do nothing', function () {
        let oldBody = $('body').html();
        nuke(5, '.target');
        expect($('body').html()).to.be.equal(oldBody)
    });

    it('Correct selectors should delete all nodes that match', function () {
        nuke('.target', '.nested');
        expect($('.target').filter('.nested').length).to.be.equal(0);
    });

    it('match * :has(p) and div, should delete all nodes', function () {
        nuke('* :has(p)', 'div');
        expect($('* :has(p)').filter('div').length).to.be.equal(0);
    });
});
