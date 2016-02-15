var button = document.getElementById('validate-button');

button.addEventListener('click', function () {
    "use strict";
    var input = document.getElementById('input'),
        div = document.getElementById('output'),
        pattern = /[\w.+-]{5,}@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+/g,
        email = input.value;
    div.textContent = email;
    if (pattern.test(email)) {
        div.style.backgroundColor = 'green';
    } else {
        div.style.backgroundColor = 'red';
    }
});