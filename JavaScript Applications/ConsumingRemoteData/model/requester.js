var Requester = (function () {
    function Requester(url, headers) {
        this.baseUrl = url;
        this.headers = headers;
    }

    Requester.prototype.makeRequest = function (method, url, data) {
        var defer = Q.defer();
        $.ajax({
            method: method,
            headers: this.headers,
            url: this.baseUrl + url,
            data: JSON.stringify(data),
            success: function (s) {
                defer.resolve(s);
            },
            error: function (e) {
                defer.reject(e);
            }
        });
        return defer.promise;
    };

    return Requester;
}());