(function () {
    var APP_ID = 'kid_W1D-ZR7pCl',
            APP_SECRET = '71343686690646ee8e8b1d1984be7e9e',
            countryNameInput = $('#country-name'),
            countriesUl = $('#all-countries'),
            headers = {
                'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
                'Content-Type': 'application/json'
            },
            COUNTRY_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/Country/',
            TOWN_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/Town',
            countryName;


    $.ajax({
        method: 'GET',
        headers: headers,
        url: COUNTRY_URL,
        success: function (data) {
            data.forEach(function (c) {
                sessionStorage[c.name] = c._id;
                $('#all-countries').append($('<li>').attr('id', c.name).text(c.name).append($('<ul>').attr('id', c.name + 'Ul')))
            })
        }
    });

    $('#add-country').on('click', function () {
        countryName = countryNameInput.val();
        if (countryName) {
            $.ajax({
                method: 'POST',
                headers: headers,
                url: COUNTRY_URL,
                data: JSON.stringify({"name": countryName}),
                success: reset
            })
        }
    });

    $('#rename-country').on('click', function () {
        countryName = countryNameInput.val();
        if (countryName) {
            var newName = prompt('New name: ');
            $.ajax({
                method: 'PUT',
                headers: headers,
                url: COUNTRY_URL + sessionStorage[countryName],
                data: JSON.stringify({'name': newName}),
                success: reset
            })
        }
    });

    $('#delete-country').on('click', function () {
        countryName = countryNameInput.val();
        if (countryName) {
            $.ajax({
                method: 'DELETE',
                headers: headers,
                url: COUNTRY_URL + sessionStorage[countryName],
                data: '{}',
                success: reset
            })
        }
    });
    countriesUl.click(function (event) {
        var countryName = event.target.id,
                countryUl = $('#' + countryName + 'Ul').html('');
        $.ajax({
            method: 'GET',
            headers: headers,
            url: TOWN_URL + '?query={"country._id":"' + sessionStorage[countryName] + '"}',
            success: function (data) {
                data.forEach(function (town) {
                    sessionStorage[town.name] = town._id;
                    countryUl.append($('<li>').attr('id', town.name).text(town.name))
                })
            }
        })
    });

    function reset() {
        location.reload();
    }
}());