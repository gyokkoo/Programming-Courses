function secretKnock() {
    let baseURL = 'https://baas.kinvey.com/appdata/kid_BJXTsSi-e/knock?query=';
    let authToken = "Basic " + btoa('guest:guest');

    let message = 'Knock Knock.';
    console.log(message);
    getNext(message);

    function getNext(message) {
        let request = {
            method: "GET",
            url: baseURL + message,
            headers: {
                "Authorization": authToken
            }
        };

        $.ajax(request)
            .then(function (success) {
                if (success.answer) {
                    console.log(success.answer)
                }
                if (success.message) {
                    console.log(success.message);
                    message = success.message;
                    getNext(message);
                }
            });
    }
}
