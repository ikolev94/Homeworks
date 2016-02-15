(function () {
    "use strict";
    var checkBox, div;
    checkBox = document.getElementById('invoice');
    div = document.getElementById('hidden');
    checkBox.addEventListener('click', function () {
        if (checkBox.checked) {
            div.style.visibility = 'visible';
        } else {
            div.style.visibility = 'hidden';
        }
    });
}());