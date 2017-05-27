function attachEvents() {
    $("#submit").click(submit);
    $("#refresh").click(refresh);
    const baseUrl = "https://messenger-bf158.firebaseio.com/messenger.json";

    function submit() {
        let message = {
            author: $('#author').val(),
            content: $('#content').val(),
            timestamp: Date.now()
        };

        $('#content').val('');
        $.post(baseUrl, JSON.stringify(message)).then(refresh);
    }

    function refresh() {
        $.get(baseUrl).then(loadData);
    }

    function loadData(data) {
        $('#messages').empty();
        let orderedMessages = {};
        data = Object.keys(data).sort((a, b) => a.timestamp - b.timestamp).forEach(k => orderedMessages[k] = data[k]);
        for (let msg of Object.keys(orderedMessages)) {
            $('#messages').append(`${orderedMessages[msg]['author']}: ${orderedMessages[msg]['content']}\n`);
        }
    }

    refresh();
}