function sum() {
    let model = getModel();
    model.init('#num1', '#num2', '#result');
    $('#sumButton').click(model.add);
    $('#subtractButton').click(model.subtract);

    function getModel() {
        let model = {
            init: function (selectorA, selectorB, resultSelector) {
                model.num1 = $(selectorA);
                model.num2 = $(selectorB);
                model.result = $(resultSelector);
            },
            add: () => model.action((a, b) => a + b),
            subtract: () => model.action((a, b) => a - b),
            action: function (operation) {
                let val1 = Number(model.num1.val());
                let val2 = Number(model.num2.val());
                model.result.val(operation(val1, val2));
            }
        };
        return model;
    }

}
