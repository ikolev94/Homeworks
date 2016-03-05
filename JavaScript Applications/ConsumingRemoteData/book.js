(function () {
    "use strict";
    var add,
        title,
        author,
        isbn,
        newTitleInput = $('#new-title'),
        newAuthorInput = $('#new-author'),
        newIsbnInput = $('#new-isbn'),
        id = Math.floor((Math.random() * 100) + 1),
        headers = {
            'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
            'Content-Type': 'application/json'
        },
        BOOKS_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/books/';
    //$('head').load('toLoad.txt style');
    //$('body').load('toLoad.txt #wrapper');

    $.ajax({
        method: 'GET',
        headers: headers,
        url: BOOKS_URL,
        success: function (data) {
            data.forEach(function (book) {
                sessionStorage[book.title] = book._id;
                $('#books')
                    .append($('<option>').attr('id', book.title).text(book.title + ' -> ' + book.author));
            });
        }
    });

    $('#add-button').click(function (ev, added) {
        add = true;
        $('#pop').removeClass('hidden').addClass('overlay');
    });

    $('#edit-button').click(function (ev, added) {
        //add = true;
        newTitleInput.val()
        $('#pop').removeClass('hidden').addClass('overlay');
    });

    $('#submit').click(function () {
        title = newTitleInput.val() || 'book' + id;
        author = newAuthorInput.val() || 'author' + id;
        isbn = newIsbnInput.val() || 'isbn' + id;
        if (add) {
            add = false;
            $.ajax({
                method: 'POST',
                headers: headers,
                url: BOOKS_URL,
                data: JSON.stringify({'title': title, 'author': author, 'isbn': isbn}),
                success: reset
            })
        } else {
            c
        }

        //$('#pop').removeClass('overlay').addClass('hidden');
    });

    function reset() {
        location.reload();
    }
}());