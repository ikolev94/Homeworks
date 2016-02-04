(function () {
    var checkBox = document.getElementById('invoice');
    var div = document.getElementById('hidden');
    checkBox.addEventListener('click', function () {
        if (checkBox.checked) {
            div.style.visibility = 'visible';
        } else {
            div.style.visibility = 'hidden';
        }
    });
}());