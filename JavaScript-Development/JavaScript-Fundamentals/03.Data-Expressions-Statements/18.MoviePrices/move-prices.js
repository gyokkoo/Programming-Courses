function moviePrices([title, day]) {
    title = title.toLowerCase();
    day = day.toLowerCase();
    if (title == "the godfather") {
        switch (day) {
            case "monday":
                return 12;
            case "tuesday" :
                return 10;
            case "wednesday" :
                return 15;
            case "thursday" :
                return 12.50;
            case "friday":
                return 15;
            case "saturday" :
                return 25;
            case "sunday":
                return 30;
            default:
                return 'Error';
        }
    } else if (title == "schindler's list") {
        switch (day) {
            case "monday":
            case "tuesday" :
            case "wednesday" :
            case "thursday" :
            case "friday":
                return 8.5;
            case "saturday" :
            case "sunday":
                return 15;
            default:
                return 'Error';
        }
    } else if (title == "casablanca") {
        switch (day) {
            case "monday":
            case "tuesday" :
            case "wednesday" :
            case "thursday" :
            case "friday":
                return 8;
            case "saturday" :
            case "sunday":
                return 10;
            default:
                return 'Error';
        }
    } else if (title == "the wizard of oz") {
        switch (day) {
            case "monday":
            case "tuesday" :
            case "wednesday" :
            case "thursday" :
            case "friday":
                return 10;
            case "saturday" :
            case "sunday":
                return 15;
            default:
                return 'Error';
        }
    } else {
        return 'Error';
    }
}

console.log(moviePrices(['The Godfather', 'Friday']));