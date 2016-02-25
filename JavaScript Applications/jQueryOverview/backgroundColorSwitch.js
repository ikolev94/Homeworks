(function () {
    ($('<ul>').append($('<li>').addClass('bird').text('Hummingbird'))
            .append($('<li>').addClass('bird').text('Nightingale'))
            .append($('<li>').text('Cat'))
            .append($('<li>').addClass('bird').text('Eagle'))
            .append($('<li>').addClass('bird').text('Sparrow'))
    ).appendTo($('#problem2'));

    $('ul').after($('<button>').attr('id', 'paint-btn').text('Paint').on('click', function (ev) {
            var color, inputClass;
            color = $('#color').val();
            inputClass = $('#input-class').val();
            if (inputClass) {
                $('.' + inputClass).css('background', color);
            }
        }))
        .after($('<input>').attr({'type': 'color', 'id': 'color'}))
        .after($('<input>').attr({'type': 'text', 'id': 'input-class', 'placeholder': 'Class: bird'}))
        .before($('<h1>').text('2. Background Color Switch'));
}());