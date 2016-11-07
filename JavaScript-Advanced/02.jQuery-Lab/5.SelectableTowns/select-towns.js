function attachEvents() {
    $('#items').on('click', 'li', function () {
        let li = $(this);
        if (li.attr('data-selected')) {
            li.removeAttr('data-selected');
            li.css('background', '');
        } else {
            li.attr('data-selected', 'true');
            li.css('background', '#DDD');
        }
    });

    $('#showTownsButton').on('click', function () {
        let selLi = $('#items li[data-selected=true]');
        let towns = selLi.toArray().map(li => li.textContent).join(', ');
        $('#selectedTowns').text("Selected towns: " + towns);
    })
}