(function () {
    var APP_ID = 'kid_W1D-ZR7pCl',
        APP_SECRET = '71343686690646ee8e8b1d1984be7e9e';

    $.ajax({
        method: 'GET',
        headers: {
            'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
            'Content-Type': 'application/json'
        },
        url :'http://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/Country',
        success: function (data) {
            data.forEach(function (c) {
                console.log(c);
                $('#wrapper').append($('<p>').text(c.name))
            })
        }
    })

}());