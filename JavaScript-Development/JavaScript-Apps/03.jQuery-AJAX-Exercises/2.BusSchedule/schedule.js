function solve() {
    const baseUrl = "https://judgetests.firebaseio.com/schedule/";
    let nextStop = "depot";
    let currentStop = undefined;

    function depart() {
        $.get(baseUrl + nextStop + ".json")
            .then(departBus)
            .catch(displayError);

        function departBus(data) {
            $('.info').text('Next stop ' + data.name);
            currentStop = data.name;
            nextStop = data.next;
            $('#depart').prop('disabled', true);
            $('#arrive').prop('disabled', false);
        }
    }

    function arrive() {
        $('.info').text('Arriving at ' + currentStop);
        $('#depart').prop('disabled', false);
        $('#arrive').prop('disabled', true);
    }

    function displayError() {
        $('.info').text("Error");
        $('#depart').prop('disabled', true);
        $('#arrive').prop('disabled', true);
    }

    return {
        depart,
        arrive
    };
}