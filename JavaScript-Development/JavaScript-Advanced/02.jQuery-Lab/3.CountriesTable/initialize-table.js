function initializeTable() {
    $('#createLink').click(function () {
        let countryName = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        appendCountryToTable(countryName, capital);
        $('#newCountryText').val('');
        $('#newCapitalText').val('');
        fixRowActions();
    });

    appendCountryToTable('Bulgaria', 'Sofia');
    appendCountryToTable('Germany', 'Berlin');
    appendCountryToTable('Russia', 'Moscow');
    fixRowActions();

    function appendCountryToTable(countryName, capital) {
        let row = $("<tr>")
            .append($("<td>").text(countryName))
            .append($("<td>").text(capital))
            .append($("<td>")
                .append($("<a href='#'>[Up]</a>").click(moveUp))
                .append(" ")
                .append($("<a href='#'>[Down]</a>").click(moveDown))
                .append(" ")
                .append($("<a href='#'>[Delete]</a>").click(deleteItem)));
        row.css('display', 'none');
        $("#countriesTable").append(row);
        row.fadeIn();

    }

    function moveUp() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.insertBefore(row.prev());
            row.fadeIn();
            fixRowActions();
        });
    }

    function deleteItem() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.remove();
            fixRowActions();
        });
    }

    function moveDown() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.insertAfter(row.next());
            row.fadeIn();
            fixRowActions();
        });
    }

    function fixRowActions() {
        $('#countriesTable a').css('display', 'inline');
        let tableRows = $('#countriesTable tr');

        $(tableRows[2]).find("a:contains('Up')").css('display', 'none');
        $(tableRows[tableRows.length - 1]).find("a:contains('Down')").css('display', 'none');

    }
}