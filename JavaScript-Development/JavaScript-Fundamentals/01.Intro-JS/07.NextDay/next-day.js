function nextDay(arr) {
    let date = new Date(arr[0], arr[1] - 1, arr[2]);
    let oneDay = 24 * 60 * 60 * 1000 // Milliseconds in 1 day
    let nextDate = new Date(date.getTime() + oneDay);

    console.log(nextDate.getFullYear() + "-" +
        (nextDate.getMonth() + 1) + "-" +
        nextDate.getDate());
}

nextDay(['2016', '9', '30']);