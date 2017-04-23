function leapYear(arr) {
    let year = Number(arr[0]);
    let isLeap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    if (isLeap) {
        console.log('yes');
    } else {
        console.log('no');
    }
}

leapYear(['2000']);