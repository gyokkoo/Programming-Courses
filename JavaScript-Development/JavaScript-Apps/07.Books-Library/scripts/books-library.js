function startApp() {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppId = "kid_r1IUXbP2";
    const kinveyAppSecret = "d65a1a31c04d49f7aaadcfaf12754ac4";
    const kinveyAuthHeaders = {
        'Authorization': "Basic " + btoa(kinveyAppId + ":" + kinveyAppSecret),
    };

    sessionStorage.clear();

    showHideMenuLinks();
    showView('viewHome');

    $("#linkHome").click(showHomeView);
    $("#linkLogin").click(showLoginView);
    $("#linkRegister").click(showRegisterView);
    $("#linkListBooks").click(listBooks);
    $("#linkCreateBook").click(showCreateBookView);
    $("#linkLogout").click(logoutUser);

    $("#formLogin").submit(loginUser);
    $("#formRegister").submit(registerUser);
    $("#btnCreateBook").click(createBook);
    $("#btnEditBook").click(editBook);

    $("#infoBox, #errorBox").click(function () {
        $(this).fadeOut();
    });

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function () {
            $("#loadingBox").show()
        },
        ajaxStop: function () {
            $("#loadingBox").hide()
        }
    });

    function showHideMenuLinks() {
        $("#menu a").hide();
        if (sessionStorage.getItem("authToken")) {
            $("#linkHome").show();
            $("#linkListBooks").show();
            $("#linkCreateBook").show();
            $("#linkLogout").show();
        } else {
            $("#linkHome").show();
            $("#linkLogin").show();
            $("#linkRegister").show();
        }
    }

    function showView(viewName) {
        $("main > section").hide();
        $("#" + viewName).show();
    }

    function showHomeView() {
        showView("viewHome");
    }

    function showLoginView() {
        $("#formLogin").trigger('reset');
        showView("viewLogin");
    }

    function showRegisterView() {
        $("#formRegister").trigger('reset');
        showView('viewRegister');
    }

    function showCreateBookView() {
        $("#formCreateBook").trigger('reset');
        showView('viewCreateBook');
    }

    function loginUser(event) {
        event.preventDefault();

        let userData = {
            username: $('#formLogin input[name=username]').val(),
            password: $('#formLogin input[name=password]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppId + "/login",
            contentType: "application/json",
            headers: kinveyAuthHeaders,
            data: JSON.stringify(userData),
            success: loginUserSuccess,
            error: handleAjaxError
        });

        function loginUserSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listBooks();
            showInfo('Login successful.');
        }
    }

    function listBooks() {
        $("#books").empty();
        showView("viewBooks");

        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppId + "/books",
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            success: loadBookSuccess,
            error: handleAjaxError
        });

        function loadBookSuccess(books) {
            let table = $(`
                <table>
                    <tr>
                        <th>Title</th>
                        <th>Author</th>
                        <th>Description</th>
                        <th>Actions</th>
                    </tr>
                </table>
                           `);
            for (let book of books) {
                let tr = $('<tr>');
                let links = [];
                if (book._acl.creator == sessionStorage.getItem('userId')) {
                    let deleteLink = $("<a href='#'>[Delete]</a>").click(function () {
                        deleteBookById(book._id);
                    });
                    let editLink = $("<a href='#'>[Edit]</a>").click(function () {
                        loadBookForEdit(book._id);
                    });
                    links.push(deleteLink);
                    links.push(" ");
                    links.push(editLink);
                }
                tr.append(
                    $("<td>").text(book.title),
                    $("<td>").text(book.author),
                    $("<td>").text(book.description),
                    $("<td>").append(links)
                );
                tr.appendTo(table);
            }
            $("#books").append(table);
        }
    }

    function deleteBookById(bookId) {
        $.ajax({
            method: "DELETE",
            url: kinveyBaseUrl + "appdata/" + kinveyAppId + "/books/" + bookId,
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            success: deleteBookSuccess,
            error: handleAjaxError
        });

        function deleteBookSuccess() {
            showInfo("Book deleted");
            listBooks();
        }
    }

    function logoutUser() {
        sessionStorage.clear();
        $("#loggedInUser").text("");
        showView("viewHome");
        showHideMenuLinks();
        showInfo("Logout successful");
    }

    function registerUser(event) {
        event.preventDefault();

        let userData = {
            username: $('#formRegister input[name=username]').val(),
            password: $('#formRegister input[name=password]').val()
        };

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppId,
            contentType: "application/json",
            headers: kinveyAuthHeaders,
            data: JSON.stringify(userData),
            success: registerSuccess,
            error: handleAjaxError
        });

        function registerSuccess(userInfo) {
            saveAuthInSession(userInfo);
            showHideMenuLinks();
            listBooks();
            showInfo('User registration successful.');
        }
    }

    function saveAuthInSession(userInfo) {
        sessionStorage.setItem('username', userInfo.username);
        sessionStorage.setItem('authToken', userInfo._kmd.authtoken);
        sessionStorage.setItem('userId', userInfo._id);
        $("#loggedInUser").text("Welcome, " + userInfo.username);
    }


    function createBook() {
        let bookData = {
            title: $("#formCreateBook input[name=title]").val(),
            author: $("#formCreateBook input[name=author]").val(),
            description: $("#formCreateBook textarea[name=description]").val(),
        };
        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "appdata/" + kinveyAppId + "/books",
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            data: bookData,
            success: createBookSuccess,
            error: handleAjaxError
        });

        function createBookSuccess() {
            showInfo("Book created.");
            listBooks();
        }
    }

    function editBook() {
        let bookData = {
            title: $("#formEditBook input[name=title]").val(),
            author: $("#formEditBook input[name=author]").val(),
            description: $("#formEditBook textarea[name=description]").val(),
        };
        let bookId = $("#formEditBook input[name=id]").val();
        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppId + "/books/" + bookId,
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            data: bookData,
            success: editBookSuccess,
            error: handleAjaxError
        });

        function editBookSuccess() {
            showInfo("Book edited.");
            listBooks();
        }
    }

    function loadBookForEdit(bookId) {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppId + "/books/" + bookId,
            headers: {
                "Authorization": "Kinvey " + sessionStorage.getItem("authToken"),
            },
            success: loadBookForEditSuccess,
            error: handleAjaxError
        });

        function loadBookForEditSuccess(book) {
            $("#formEditBook input[name=id]").val(book._id);
            $("#formEditBook input[name=title]").val(book.title);
            $("#formEditBook input[name=author]").val(book.author);
            $("#formEditBook textarea[name=description]").val(book.description);
            showView("viewEditBook");
        }
    }

    function showInfo(message) {
        $('#infoBox').text(message);
        $('#infoBox').show();
        setTimeout(function () {
            $('#infoBox').fadeOut()
        }, 3000);
    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0) {
            errorMsg = "Cannot connect due to network error.";
        }
        if (response.responseJSON && response.responseJSON.description) {
            errorMsg = response.responseJSON.description;
        }

        showError(errorMsg);
    }

    function showError(errorMsg) {
        $("#errorBox").text("Error: " + errorMsg);
        $("#errorBox").show();
    }
}