function imperialUnits(inches) {
    let feet = Math.floor(inches / 12);
    let feetInches = inches % 12;

    console.log(`${feet}'-${feetInches}"`);
}

imperialUnits(55);