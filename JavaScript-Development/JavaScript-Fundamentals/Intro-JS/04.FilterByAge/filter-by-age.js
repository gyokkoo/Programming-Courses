function filterByAge(arr) {
    let minimumAge = Number(arr[0]);
    let firstPerson = {name: arr[1], age: Number(arr[2])};
    let secondPerson = {name: arr[3], age: Number(arr[4])};

    if (firstPerson.age >= minimumAge) {
        console.log(firstPerson);
    }
    if (secondPerson.age >= minimumAge) {
        console.log(secondPerson);
    }
}

filterByAge(['12', 'Ivan', '15', 'Asen', '9']);