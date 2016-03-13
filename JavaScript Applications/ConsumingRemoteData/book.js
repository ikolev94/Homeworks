$(document).ready(function () {
    "use strict";
    var toAdd,
        booksSelect = $('#books'),
        pop = $('#pop'),
        headers = {
            'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
            'Content-Type': 'application/json'
        },
        COLLECTION_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/';

    var requester = new Requester(COLLECTION_URL, headers);
    var model = new BookModel(requester);
    var controller = new Controller(model);

    controller.getBooks();

    $('#add-button').click(function () {
        toAdd = true;
        pop.removeClass('hidden').addClass('overlay');
    });

    $('#edit-button').click(function () {
        if (booksSelect.val()) {
            pop.removeClass('hidden').addClass('overlay');
        } else {
            alert('Select book.');
        }
    });

    $('#submit').click(function () {
        if (toAdd) {
            toAdd = false;
            controller.addBook();
        } else {
            controller.editBook();
        }
        pop.removeClass('overlay').addClass('hidden');
    });

    $('#cancel').click(function () {
        pop.removeClass('overlay').addClass('hidden');
    });

    $('#delete-button').click(function () {
        if (booksSelect.val()) {
            controller.deleteBook();
        } else {
            alert('Select book.');
        }
    });
});