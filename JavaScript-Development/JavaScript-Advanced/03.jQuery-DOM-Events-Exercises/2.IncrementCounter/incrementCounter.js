function increment(selector) {
    var container = $(selector);
    var fragment = document.createDocumentFragment();
    var textArea = $("<textarea></textarea>");
    var incrementBtn = $("<button>Increment</button>");
    var addBtn = $('<button>Add</button>');
    var list = $("<ul>");

    textArea.val(0);
    textArea.addClass("counter");
    textArea.attr("disabled", true);
    incrementBtn.addClass("btn");
    incrementBtn.attr("id", "incrementBtn");
    addBtn.addClass("btn");
    addBtn.attr("id", "addBtn");
    list.addClass("results");

    incrementBtn.on("click", function (event) {
        var value = parseInt(textArea.val());
        textArea.val(++value);
    });

    addBtn.on("click", function (event) {
        var value = parseInt(textArea.val());
        var li = $("<li>");
        li.text(value);
        list.append(li);
    });

    textArea.appendTo(fragment);
    incrementBtn.appendTo(fragment);
    addBtn.appendTo(fragment);
    list.appendTo(fragment);

    container.append(fragment);
}