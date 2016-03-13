var BookModel = (function () {
    function BookModel(requester) {
        this.requester = requester;
    }

    BookModel.prototype.getBooks = function (url) {
        return this.requester.makeRequest('GET', url, null);
    };

    BookModel.prototype.addBook = function (url, data) {
        return this.requester.makeRequest('POST', url, data);
    };

    BookModel.prototype.editBook = function (url, data) {
        return this.requester.makeRequest('PUT', url, data);
    };
    BookModel.prototype.deleteBook = function (url, data) {
        return this.requester.makeRequest('DELETE', url, data)
    };

    return BookModel;
}());
