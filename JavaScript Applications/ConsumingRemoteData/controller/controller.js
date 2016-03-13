var Controller = (function () {
    var id = Math.floor((Math.random() * 100) + 1),
        booksSelect = $('#books'),
        newTitleInput = $('#new-title'),
        newAuthorInput = $('#new-author'),
        newIsbnInput = $('#new-isbn'),
        pop = $('#pop');

    function Controller(model) {
        this.model = model;
    }

    function getData() {
        return data = {
            title: newTitleInput.val(),
            author: newAuthorInput.val(),
            isbn: newIsbnInput.val()
        };
    }

    Controller.prototype.addBook = function () {
        var data = getData();
        if (!data.author || !data.title || !data.isbn || sessionStorage[data.title]) {
            console.warn('Invalid Book');
            return false;
        }
        this.model.addBook('books', data)
            .then(function (s) {
                sessionStorage[s.title] = s._id;
                $.get('templates/book.html', function (template) {
                    var output = Mustache.render(template, {books: data});
                    booksSelect.append(output);
                })
            }).done();
    };

    Controller.prototype.getBooks = function () {
        this.model.getBooks('books')
            .then(function (books) {
                sessionStorage.clear();
                var booksData = {
                    books: books
                };
                books.forEach(function (book) {
                    sessionStorage[book.title] = book._id;
                });
                $.get('templates/book.html', function (template) {
                    var output = Mustache.render(template, booksData);
                    booksSelect.append(output);
                })
            }).done();
    };

    Controller.prototype.editBook = function () {
        var data = getData();
        if (!data.author || !data.title || !data.isbn || sessionStorage[data.title]) {
            console.warn('Invalid Book');
            return false;
        }
        this.model.editBook('books/' + sessionStorage[$('option:selected').attr('id')], data)
            .then(function (s) {
                sessionStorage[s.title] = s._id;
                $.get('templates/book.html', function (template) {
                    var output = Mustache.render(template, {books: data});
                    var selectedOne = $('option:selected');
                    selectedOne.before(output);
                    selectedOne.remove();
                })
            }).done();
    };
    Controller.prototype.deleteBook = function () {
        var title = $('option:selected').attr('id');
        this.model.deleteBook('books/' + sessionStorage[title], {})
            .then(function (s) {
                sessionStorage.removeItem(title);
                $('option:selected').hide('slow', function () {
                    $('option:selected').remove();
                });
            }).done();
    };


    return Controller;
}());