var button = document.getElementById('validate-button').onclick = function () {
    document.getElementById('output').style.backgroundColor = 'red';
};

//button.addEventListener('click', function () {
//    var input = document.getElementById('input');
//    var email = input.value;
//    var pattern = /[\w.+-]{5,}@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+/g;
//    var div = document.getElementById('output');
//    var isValid = email.match(pattern);

    //div.innerText = email;
    //if (isValid) {
    //div.style.backgroundColor = 'green';
    //} else {
    //    div.style.background = 'red';
    //}
//});

//function changeColor(email,isValid) {
//    var div = document.getElementById('output');
//    div.innerText = email;
//    if (isValid) {
//        div.style.background = 'green';
//    } else {
//        div.style.background = 'red';
//    }
//}