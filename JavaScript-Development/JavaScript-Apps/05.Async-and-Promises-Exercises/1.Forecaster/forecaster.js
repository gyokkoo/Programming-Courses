function attachEvents() {
    const baseServiceUrl = 'https://judgetests.firebaseio.com/';
    const symbols = {
        ['Sunny']: '&#x2600;',
        ['Partly sunny']: '&#x26C5;',
        ['Overcast']: '&#x2601;',
        ['Rain']: '&#x2614;',
        ['Degrees']: '&#176;'
    };

    $('#submit').click(getWeatherData);

    function getWeatherData() {
        $.get(baseServiceUrl + 'locations.json')
            .then(loadForecast)
            .catch(displayError);
    }

    function loadForecast(locations) {
        let currentLocation = $('#location').val();
        let locationCode;
        for (let location of locations) {
            if (currentLocation === location.name) {
                locationCode = location.code;
            }
        }

        let todayForecast = $.get(baseServiceUrl + 'forecast/today/' + locationCode + '.json');
        let upcomingForecast = $.get(baseServiceUrl + 'forecast/upcoming/' + locationCode + '.json');

        Promise.all([todayForecast, upcomingForecast])
            .then(displayForecast)
            .catch(displayError);

        function displayForecast([today, upcoming]) {
            $('#forecast').show();

            $('#current').append($('<span>').html(symbols[today.forecast.condition]).attr('class', 'symbol'));
            let span = $('<span>').attr('class', 'condition');
            span.append($('<span>').html(today.name).attr('class', 'forecast-data'));
            span.append($('<span>').html(today.forecast.low + "/" + today.forecast.high)
                .attr('class', 'forecast-data'));
            span.append($('<span>').html(today.forecast.condition).attr('class', 'forecast-data'));
            $('#current').append(span);

            for (let forecast of upcoming.forecast) {
                let span = $('<span>').attr('class', 'upcoming');
                span.append($('<span>').html(symbols[forecast.condition]).attr('class', 'symbol'));
                span.append($('<span>').html(`${forecast.low}${symbols['Degrees']}/${forecast.high}${symbols['Degrees']}`)
                    .attr('class', 'forecast-data'));
                span.append($('<span>').html(forecast.condition).attr('class', 'forecast-data'));
                $('#upcoming').append(span);
            }
        }
    }

    function displayError(error) {
        $('#forecast').text('Error');
    }
}