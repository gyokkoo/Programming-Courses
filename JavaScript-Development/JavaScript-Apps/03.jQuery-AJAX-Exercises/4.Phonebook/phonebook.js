function attachEvents() {
    $('#btnLoad').click(loadContacts);
    $('#btnCreate').click(createContact);

    const baseUrl = 'https://phonebook-nakov.firebaseio.com/phonebook';

    function loadContacts() {
        $('#phonebook').empty();
        $.get(baseUrl + '.json')
            .then(displayContacts)
            .catch(displayError);
    }

    function displayContacts(contacts) {
        for (let key in contacts) {
            let person = contacts[key]['person'];
            let phone = contacts[key]['phone'];

            $('#phonebook')
                .append($('<li>').text(person + ': ' + phone + ' ')
                    .append($('<button>').text('Delete').click(function () {
                        deleteContact(key)
                    })));
        }
    }

    function displayError() {
        $('#phonebook').html("<li>Error<li>")
    }

    function deleteContact(key) {
        let delRequest = {
            method: "DELETE",
            url: baseUrl + '/' + key + ".json"
        };
        $.ajax(delRequest)
            .then(loadContacts)
            .catch(displayError);

    }

    function createContact() {
        let person = $('#person').val();
        let phone = $('#phone').val();
        let newContact = {
            person, phone
        };

        let createRequest = {
            method: "POST",
            url: baseUrl + ".json",
            data: JSON.stringify(newContact)
        };
        $.ajax(createRequest)
            .then(loadContacts)
            .catch(displayError);
        $('#person').val('');
        $('#phone').val('');
    }
}