function attachEvents() {
    const baseServiceURL = 'https://baas.kinvey.com/appdata/';
    const appId = 'kid_Bk-bh-j-b';
    const collectionName = 'biggestCatches';

    let btoaAuth = btoa('guest:guest');

    $('.load').click(loadCatches);
    $('.add').click(addCatch);

    function loadCatches() {
        let request = {
            method: "GET",
            url: baseServiceURL + appId + '/' + collectionName,
            headers: {
                "Authorization": "Basic " + btoaAuth
            }
        };

        $.ajax(request)
            .then(displayCatches)
            .catch(displayError);

        function displayCatches(data) {
            $('#catches').empty();

            for (let fishCatch of data) {
                $('#catches')
                    .append($('<div>').attr('class', 'catch').attr('data-id', fishCatch._id)
                        .append($('<label>').text('Angler'))
                        .append($('<input>').attr('type', 'text').attr('class', 'angler').val(fishCatch.angler))
                        .append($('<label>').text('Weight'))
                        .append($('<input>').attr('type', 'number').attr('class', 'weight').val(fishCatch.weight))
                        .append($('<label>').text('Species'))
                        .append($('<input>').attr('type', 'text').attr('class', 'species').val(fishCatch.species))
                        .append($('<label>').text('Location'))
                        .append($('<input>').attr('type', 'text').attr('class', 'location').val(fishCatch.location))
                        .append($('<label>').text('Bait'))
                        .append($('<input>').attr('type', 'text').attr('class', 'bait').val(fishCatch.bait))
                        .append($('<label>').text('Capture Time'))
                        .append($('<input>').attr('type', 'number').attr('class', 'captureTime').val(fishCatch.captureTime))
                        .append($('<button>').attr('class', 'update').text('Update').click(updateCatch))
                        .append($('<button>').attr('class', 'delete').text('Delete').click(deleteCatch))
                    )
            }
        }
    }

    function addCatch() {
        let addForm = $('#addForm');
        let request = {
            method: "POST",
            url: baseServiceURL + appId + '/' + collectionName,
            headers: {
                "Authorization": "Basic " + btoaAuth,
                "Content-type": "application/json"
            },
            data: JSON.stringify({
                angler: addForm.find('> .angler').val(),
                weight: Number(addForm.find('> .weight').val()),
                species: addForm.find('> .species').val(),
                location: addForm.find('> .location').val(),
                bait: addForm.find('> .bait').val(),
                captureTime: Number(addForm.find('> .captureTime').val())
            })
        };

        $.ajax(request)
            .then(loadCatches)
            .catch(displayError);

        addForm.find('> .angler').val('');
        addForm.find('> .weight').val('');
        addForm.find('> .species').val('');
        addForm.find('> .location').val('');
        addForm.find('> .bait').val('');
        addForm.find('> .captureTime').val('');
    }

    function updateCatch() {
        let currentForm = $(this).parent();
        let catchId = $(this).parent().attr('data-id');
        let request = {
            method: "PUT",
            url: baseServiceURL + appId + '/' + collectionName + '/' + catchId,
            headers: {
                "Authorization": "Basic " + btoaAuth,
                "Content-type": "application/json"
            },
            data: JSON.stringify({
                angler: currentForm.find('> .angler').val(),
                weight: Number(currentForm.find('> .weight').val()),
                species: currentForm.find('> .species').val(),
                location: currentForm.find('> .location').val(),
                bait: currentForm.find('> .bait').val(),
                captureTime: Number(currentForm.find('> .captureTime').val())
            })
        };

        $.ajax(request)
            .then(loadCatches)
            .catch(displayError);
    }

    function deleteCatch() {
        let catchId = $(this).parent().attr('data-id');
        let request = {
            method: "DELETE",
            url: baseServiceURL + appId + '/' + collectionName + '/' + catchId,
            headers: {
                "Authorization": "Basic " + btoa('guest:guest'),
                "Content-type": "application/   json"
            }
        };

        $.ajax(request)
            .then(loadCatches)
            .catch(displayError)
    }

    function displayError() {
        alert('Error');
    }
}