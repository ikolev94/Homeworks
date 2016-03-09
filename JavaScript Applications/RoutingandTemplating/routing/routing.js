(function () {

    function showMessage(name) {
        $('h2').text('Hello, ' + name);
    }

    var router = Sammy(function () {
        this.get('#/Ivan', function () {
            showMessage('Ivan');
        });
        this.get('#/Georgi', function () {
            showMessage('Georgi');
        });
        this.get('#/Mariq', function () {
            showMessage('Mariq');
        });
        this.get('#/Bogomil', function () {
            showMessage('Bogomil');
        });
    });

    router.run('#/Ivan');
}());