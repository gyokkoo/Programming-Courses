function loadCommits() {
    $('#commits').empty();
    const baseUrl = 'https://api.github.com/repos/';
    let username = $('#username').val();
    let repo = $('#repo').val();
    $.get(baseUrl + username + "/" + repo + "/commits")
        .then(displayCommits)
        .catch(displayError);

    function displayCommits(commits) {
        for (let commit of commits) {
            $('#commits').append($('<li>').text(commit.commit.author.name + ": " + commit.commit.message));
        }
    }

    function displayError(err) {
        $('#commits').append($("<li>").text("Error: " + err.status + ' (' + err.statusText + ')'));
    }
}