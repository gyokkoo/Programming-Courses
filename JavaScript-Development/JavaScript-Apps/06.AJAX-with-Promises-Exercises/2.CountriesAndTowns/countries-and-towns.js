function attachEvents() {
    const appKey = 'kid_HJ8Hsd3bW';
    const baseUrl = `https://baas.kinvey.com/appdata/${appKey}/countries`;
    const username = 'guest';
    const password = 'guest';

    let authHeaders = {
        "Authorization": "Basic " + btoa(username + ":" + password),
        "Content-Type": "application/json"
    };

    $('#addCountryBtn').click(addCountry);
    $('#editCountryBtn').click(editCountry);

    loadCountries();
    // var trid = $(this).closest('tr').attr('id');
    function loadCountries() {
        $.ajax({
            url: baseUrl,
            method: "GET",
            headers: authHeaders,
        }).then(displayCountries)
            .catch(displayError);

        function displayCountries(countries) {
            let table = $('#countriesTable');
            for (let country of countries) {
                let row = $("<tr>").attr('id', country._id)
                    .append($("<td>").text(country.name))
                    .append($("<td>")
                        .append($("<button>").text("Edit").click(displayEditCountry))
                        .append(" ")
                        .append($("<button>").text("Delete").click(deleteCountry))
                        .append(" ")
                        .append($("<button>").text("Select").click(selectCountry))
                    );
                row.css('display', 'none');
                table.append(row);
                row.fadeIn();
            }
        }

        function displayEditCountry() {
            let id = $(this).closest('tr').attr('id');
            alert(id);
            $('#currentCountryId').val(id);
            $('#editCountry').css('display', 'block');
        }
    }

    function addCountry() {
        let countryName = $('#newCountryText').val();
        let countryId = $('#newCountryText')
        let country = {
            name: countryName
        };

        $.ajax({
            url: baseUrl,
            method: "POST",
            headers: authHeaders,
            data: JSON.stringify(country)
        }).then((data) => {
            let row = $("<tr>").attr('id', countryId)
                .append($("<td>").text(country.name))
                .append($("<td>")
                    .append($("<button>").text("Edit").click(displayEditCountry))
                    .append(" ")
                    .append($("<button>").text("Delete").click(deleteCountry))
                    .append(" ")
                    .append($("<button>").text("Select").click(selectCountry))
                );
            $('#countriesTable').append(row);
        });
        $('#newCountryText').val('');
    }

    function editCountry() {
        let countryId = $('#currentCountryId').val();
        let countryNewName = $('#editCountryInput').val();
        newCountry = {
            name: countryNewName,
        };

        $.ajax({
            url: baseUrl + "/" + countryId,
            method: "PUT",
            headers: authHeaders,
            data: JSON.stringify(newCountry)
        }).then(() => {
            $('#' + countryId + ' td').eq(0).html(countryNewName);
            $('#editCountry').fadeOut();
        }).catch(displayError);

        $('#editCountryInput').val(' ');
    }

    function deleteCountry() {
        let id = $(this).closest('tr').attr('id');
        alert(id);
        $.ajax({
            url: baseUrl + "/" + id,
            method: "DELETE",
            headers: authHeaders,
        }).then(() => {
            $(this).parents('tr').find('td').fadeOut();
        })
    }

    function selectCountry() {
        // TODO
    }

    function displayError() {
        alert('Error');
    }
}