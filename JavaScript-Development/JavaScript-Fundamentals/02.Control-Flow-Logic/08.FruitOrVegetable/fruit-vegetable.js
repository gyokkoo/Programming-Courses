function fruitVegetable(args) {
    let fruits = ['banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes', 'peach'];
    let vegetables = ['tomato', 'cucumber', 'pepper', 'onion', 'garlic', 'parsley'];

    let food = args[0];
    if (fruits.indexOf(food) != -1) {
        console.log('fruit');
    } else if (vegetables.indexOf(food) != -1) {
        console.log('vegetable');
    } else {
        console.log('unknown');
    }
}

fruitVegetable(['pizza']);