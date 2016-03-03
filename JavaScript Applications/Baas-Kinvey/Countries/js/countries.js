(function () {
    "use strict";
    var countryNameInput = $('#country-name'),
            townNameInput = $('#town-name'),
            countriesUl = $('#all-countries'),
            headers = {
                'Authorization': 'Kinvey b65bc048-9cc4-48de-ad9f-9174cf2a84bf.45nQeMeS4rAV3gcF56pnd/8MMY975gEVzE+yAb0NFos=',
                'Content-Type': 'application/json'
            },
            COUNTRY_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/Country/',
            TOWN_URL = 'https://baas.kinvey.com/appdata/kid_W1D-ZR7pCl/Town/',
            countryName,
            townName;


    $.ajax({
        method: 'GET',
        headers: headers,
        url: COUNTRY_URL,
        success: function (data) {
            data.forEach(function (c) {
                sessionStorage[c.name] = c._id;
                $('#all-countries')
                        .append($('<li>').attr('id', c.name).text(c.name)
                                .append($('<ul>').attr('id', c.name + 'Ul')));
            });
        }
    });

    $('#add-country').click(function () {
        countryName = countryNameInput.val();
        if (countryName) {
            $.ajax({
                method: 'POST',
                headers: headers,
                url: COUNTRY_URL,
                data: JSON.stringify({"name": countryName}),
                success: reset
            });
        }
    });

    $('#rename-country').click(function () {
        countryName = countryNameInput.val();
        if (countryName) {
            var newName = prompt('New name: ') || 'default name';
            $.ajax({
                method: 'PUT',
                headers: headers,
                url: COUNTRY_URL + sessionStorage[countryName],
                data: JSON.stringify({'name': newName}),
                success: reset
            });
        }
    });

    $('#delete-country').click(function () {
        countryName = countryNameInput.val();
        deleteItem(countryName,COUNTRY_URL);
    });

    countriesUl.click(function (event) {
        var countryName = event.target.id,
                countryUl = $('#' + countryName + 'Ul').html('');
        $('#town-buttons').fadeTo('slow', 1);
        $('#current-country').text(countryName+'=>');
        sessionStorage['currentCountry'] = countryName;
        $.ajax({
            method: 'GET',
            headers: headers,
            url: TOWN_URL + '?query={"country":"' + countryName + '"}',
            success: function (data) {
                data.forEach(function (town) {
                    sessionStorage[town.name] = town._id;
                    countryUl.append($('<li>').attr('id', town.name).text(town.name));
                });
            }
        });
    });

    $('#add-town').click(function () {
        townName = townNameInput.val();
        if (townName) {
            $.ajax({
                method: 'POST',
                headers: headers,
                url: TOWN_URL,
                data: JSON.stringify({"name": townName, 'country': sessionStorage['currentCountry']}),
                success: reset
            })
        }
    });

    $('#rename-town').click(function () {
        townName = townNameInput.val();
        if (townName) {
            var newName = prompt('New name: ') || 'default name';
            $.ajax({
                method: 'PUT',
                headers: headers,
                url: TOWN_URL + sessionStorage[townName],
                data: JSON.stringify({'name': newName, 'country': sessionStorage['currentCountry']}),
                success: reset
            })
        }
    });

    $('#delete-town').click(function () {
        townName = townNameInput.val();
        deleteItem(townName,TOWN_URL);
    });

    function deleteItem(name, url) {
        if (name) {
            $.ajax({
                method: 'DELETE',
                headers: headers,
                url: url + sessionStorage[name],
                data: '{}',
                success: reset
            })
        }
    }

    function reset() {
        location.reload();
    }
}());