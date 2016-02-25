(function () {
    $('<p>').text('I\'m a p tag').appendTo($('#problem1'));
    $('p').before($('<h1>').text('1. Element Insertion'))
        .before($('<div>').css({"background": "red", "height": "10px"}))
        .after($('<input>').attr({'type': 'password', 'id': 'color-picker'}));
    $('input').before(
        $('<label>').text('Password: ').attr('for', 'color-picker'));
}());

