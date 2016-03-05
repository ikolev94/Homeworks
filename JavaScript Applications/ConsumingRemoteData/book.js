$(document).ready(function () {
    "use strict";
    var toAdd,
        title,
        author,
        isbn,
        booksSelect = $('#books'),
        newTitleInput = $('#new-title'),
        newAuthorInput = $('#new-author'),
        newIsbnInput = $('#new-isbn'),
        pop = $('#pop'),
        id = Math.floor((Math.random() * 100) + 1),
        headers = {
            'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
            'Content-Type': 'application/json'
        },
        BOOKS_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/books/';

    makeRequest('GET', listBooks, '');

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
        title = newTitleInput.val() || 'book' + id;
        author = newAuthorInput.val() || 'author' + id;
        isbn = newIsbnInput.val() || 'isbn' + id;
        if (toAdd) {
            toAdd = false;
            makeRequest('POST', reset, '');
        } else {
            makeRequest('PUT', reset, sessionStorage[$('option:selected').attr('id')]);
        }
    });

    $('#cancel').click(function () {
        pop.removeClass('overlay').addClass('hidden');
    });

    $('#delete-button').click(function () {
        if (booksSelect.val()) {
            makeRequest('DELETE', reset, sessionStorage[$('option:selected').attr('id')])
        } else {
            alert('Select book.');
        }
    });

    function makeRequest(method, callback, id) {
        $.ajax({
            method: method,
            headers: headers,
            url: BOOKS_URL + id,
            data: JSON.stringify({'title': title, 'author': author, 'isbn': isbn}),
            success: callback
        })
    }

    function reset() {
        location.reload();
    }

    function listBooks(data) {
        data.forEach(function (book) {
            sessionStorage[book.title] = book._id;
            booksSelect.append(
                $('<option>')
                    .attr('id', book.title)
                    .text(book.title + ' => ' + book.author));
        });
    }
});