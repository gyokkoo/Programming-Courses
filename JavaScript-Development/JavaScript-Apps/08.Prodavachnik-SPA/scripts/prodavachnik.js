function startApp() {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_HJ8Hsd3bW";
    const kinveyAppSecret = "f95bfcdf07b048fe96e150686fad2fc4";
    const kinveyAuthHeaders = {
        'Authorization': "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret),
    };

    sessionStorage.clear();

    $('#linkHome').click(showHomeView);
    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListAds').click(listAdvertisements);
    $('#linkCreateAd').click(showCreateView);
    $('#linkLogout').click(logoutUser);

    $('#buttonLoginUser').click(loginUser);
    $('#buttonRegisterUser').click(registerUser);
    $('#buttonCreateAd').click(createAd);
    $('#buttonEditAd').click(editAd);

    $('#infoBox, #errorBox').click(function () {
        $(this).fadeOut();
    });

    $(document).on({
        ajaxStart: function () {
            $('#loadingBox').show();
        },
        ajaxStop: function () {
            $('#loadingBox').hide();
        }
    });


    showView('viewHome');
    showHideMenuLinks();

    function showHideMenuLinks() {
        $("#menu a").hide();
        if (sessionStorage.getItem('authToken')) {
            $("#linkHome").show();
            $("#linkListAds").show();
            $("#linkCreateAd").show();
            $("#linkLogout").show();
        } else {
            $("#linkHome").show();
            $("#linkLogin").show();
            $("#linkRegister").show();
        }
    }

    function showHomeView() {
        showView('viewHome');
    }

    function showLoginView() {
        $("#formLogin").trigger('reset');
        showView('viewLogin');
    }

    function showRegisterView() {
        $("#formRegister").trigger('reset');
        showView('viewRegister');
    }

    function showCreateView() {
        $("#formCreateAd").trigger('reset');
        showView('viewCreateAd');
    }

    function showView(viewName) {
        $('main > section').hide();
        $('#' + viewName).show();
    }

    function listAdvertisements() {
        $('#ads').empty();
        showView('viewAds');

        $.ajax({
            method: 'GET',
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + '/prodavachnik',
            headers: {
                'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken'),
            },
            success: loadAdvertisementsSuccess,
            error: handleAjaxError
        });

        function loadAdvertisementsSuccess(ads) {
            let table = $(`
                <table>
                    <tr>
                        <th>Title</th>
                        <th>Description</th>
                        <th>Publisher</th>
                        <th>Date Published</th>
                        <th>Price</th>
                        <th>Actions</th>
                    </tr>
                </table>
                           `);
            for (let ad of ads) {
                let tr = $('<tr>');
                let links = [];
                if (ad._acl.creator == sessionStorage.getItem('userId')) {
                    let deleteLink = $("<a href='#'>[Delete]</a>").click(function () {
                        deleteAdById(ad._id);
                    });
                    let editLink = $("<a href='#'>[Edit]</a>").click(function () {
                        loadAdForEdit(ad._id);
                    });
                    links.push(deleteLink);
                    links.push(" ");
                    links.push(editLink);
                }
                tr.append(
                    $("<td>").text(ad.title),
                    $("<td>").text(ad.description),
                    $("<td>").text(ad.publisher),
                    $("<td>").text(ad.date),
                    $("<td>").text(ad.price),
                    $("<td>").append(links)
                );
                tr.appendTo(table);
            }
            $("#ads").append(table);

        }
    }

    function deleteAdById(id) {
        $.ajax({
            method: 'DELETE',
            url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/prodavachnik/' + id,
            headers: {
                'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken'),
            },
            success: deleteAdSuccess,
            error: handleAjaxError
        });

        function deleteAdSuccess() {
            listAdvertisements();
            showInfo('Ad deleted');
        }
    }

    function loadAdForEdit(id) {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/prodavachnik/" + id,
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            success: loadAdForEditSuccess,
            error: handleAjaxError
        });

        function loadAdForEditSuccess(ad) {
            $("#formEditAd input[name=id]").val(ad._id);
            $("#formEditAd input[name=publisher]").val(ad.publisher);
            $("#formEditAd input[name=title]").val(ad.title);
            $("#formEditAd textarea[name=description]").val(ad.description);
            $("#formEditAd input[name=datePublished]").val(ad.date);
            $("#formEditAd input[name=price]").val(ad.price);
            showView('viewEditAd');
        }
    }

    function editAd() {
        let adsData = {
            title: $('#formEditAd input[name=title]').val(),
            description: $('#formEditAd textarea[name=description]').val(),
            publisher: sessionStorage.getItem('username'),
            date: $('#formEditAd input[name=datePublished]').val(),
            price: Number($('#formEditAd input[name=price]').val()).toFixed(2),
        };

        let adId = $("#formEditAd input[name=id]").val();
        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/prodavachnik/" + adId,
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            data: adsData,
            success: editAdSuccess,
            error: handleAjaxError
        });

        function editAdSuccess() {
            listAdvertisements();
            showInfo("Ad edited.");
        }
    }

    function createAd() {
        let adsData = {
            title: $('#formCreateAd input[name=title]').val(),
            description: $('#formCreateAd textarea[name=description]').val(),
            publisher: sessionStorage.getItem('username'),
            date: $('#formCreateAd input[name=datePublished]').val(),
            price: Number($('#formCreateAd input[name=price]').val()).toFixed(2),
        };

        $.ajax({
            method: 'POST',
            url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/prodavachnik',
            contentType: 'application/json',
            headers: {
                'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')
            },
            data: JSON.stringify(adsData),
            success: createAdSuccess,
            error: handleAjaxError
        });

        function createAdSuccess() {
            listAdvertisements();
            showInfo('Advertisement created');
        }
    }

    function loginUser() {
        let userData = {
            username: $('#formLogin input[name=username]').val(),
            password: $('#formLogin input[name=passwd]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + 'user/' + kinveyAppKey + '/login',
            contentType: 'application/json',
            headers: kinveyAuthHeaders,
            data: JSON.stringify(userData),
            success: loginUserSuccess,
            error: handleAjaxError
        });

        function loginUserSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listAdvertisements();
            showInfo('Login successful');
        }
    }

    function registerUser() {
        let userData = {
            username: $('#formRegister input[name=username]').val(),
            password: $('#formRegister input[name=passwd]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey,
            contentType: "application/json",
            headers: kinveyAuthHeaders,
            data: JSON.stringify(userData),
            success: registerUserSuccess,
            error: handleAjaxError
        });

        function registerUserSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listAdvertisements();
            showInfo('User registration successful');
        }
    }

    function saveAuthInSession(userInfo) {
        sessionStorage.setItem('username', userInfo.username);
        sessionStorage.setItem('authToken', userInfo._kmd.authtoken);
        sessionStorage.setItem('userId', userInfo._id);
        $('#loggedInUser').text('Welcome, ' + userInfo.username);
    }

    function logoutUser() {
        sessionStorage.clear();
        $('#loggedInUser').text('');
        showView('viewHome');
        showHideMenuLinks();
        showInfo('Logout successful');
    }


    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0) {
            errorMsg = 'Cannot connect due to network'
        }
        if (response.responseJSON && response.responseJSON.description) {
            errorMsg = response.responseJSON.description;
        }

        showError(errorMsg);
    }

    function showError(errorMsg) {
        $('#errorBox').text('Error ' + errorMsg);
        $('#errorBox').show();
    }

    function showInfo(message) {
        $('#infoBox').text(message);
        $('#infoBox').show();
        setTimeout(function () {
            $('#infoBox').fadeOut();
        }, 2000);
    }
}