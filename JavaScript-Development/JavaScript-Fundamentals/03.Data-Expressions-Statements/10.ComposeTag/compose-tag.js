function composeTag(args) {
    let fileLocation = args[0];
    let alternateText = args[1];

    console.log(`<img src="${fileLocation}" alt="${alternateText}">`);
}

composeTag(['smiley.gif', 'Smiley Face']);