function getInfo() {
    const baseUrl = "https://judgetests.firebaseio.com/businfo/";
    $('#stopName').text('');
    $('#buses').empty();

    let stopId = $('#stopId').val();
    $.get(baseUrl + stopId + ".json")
        .then(displayBusData)
        .catch(displayError);

    function displayBusData(data) {
        $('#stopName').text(data["name"]);

        for (let bus in data["buses"]) {
            let message = `Bus ${bus} arrives in ${data["buses"][bus]} minutes`;
            $('#buses').append($('<li>').text(message));
        }
    }

    function displayError() {
        $('#stopName').text("Error");
    }
}