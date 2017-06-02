function lastMonth(args) {
    let day = args[0] + 1;
    let month = args[1];
    let year = args[2];

    let days = daysInMonth(month - 1, year);
    console.log(days);

    function daysInMonth(month, year) {
        return new Date(year, month, 0).getDate();
    }
}

lastMonth([17, 3, 2002]);