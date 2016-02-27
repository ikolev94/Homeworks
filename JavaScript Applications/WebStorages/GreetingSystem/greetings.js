(function () {
    "use strict";
    var usernameInput,
        button,
        message,
        info;

    $('<form id="form">').css('text-align', 'center').appendTo(document.body);
    $('#form').append($('<input>').attr({'type': 'text', 'id': 'username', 'placeholder': 'Username'})
        , $('<button>').text('Save').attr({'id': 'save-btn', 'type': 'submit'})
        , $('<div>').css({'background': 'red', 'height': '200px'}));

    usernameInput = $('#username');
    button = $('#save-btn');

    button.on('click', function () {
        localStorage['username'] = usernameInput.val();

        updateSectionStorage();

        if (!localStorage['totalVisits']) {
            localStorage['totalVisits'] = 0;
        }
    });

    if (localStorage['username']) {
        updateSectionStorage();
        message = 'Hello, ' + localStorage.username + '!';
        info = $('<p>').text('Total visits: '
            + localStorage.totalVisits + ' / Session visits: '
            + sessionStorage['sessionVisits']);

        usernameInput.hide();
        button.text('Logout');

        sessionStorage['sessionVisits']++;
        localStorage['totalVisits']++;

        $('div').text(message)
            .css({
                'background': 'green'
                , 'background-image': 'url(star-trek.jpg)'
                , 'background-repeat': 'no-repeat'
            });
        info.appendTo('form');
    }


    function updateSectionStorage() {
        if (typeof (sessionStorage['sessionVisits']) !== 'string' || isNaN(sessionStorage['sessionVisits'])) {
            sessionStorage['sessionVisits'] = 0;
        }
    }
}());