function solve(input) {
    var towns = {};
    for (var i = 0; i < input.length; i++) {
        var inputArgs = input[i].replace(/\s+/g, ' ').split('|');
        var inputBand = inputArgs[0].trim();
        var inputTown = inputArgs[1].trim();
        var inputVenue = inputArgs[3].trim();

        if (!towns[inputTown]) {
            towns[inputTown] = {};
        }

        if (!towns[inputTown][inputVenue]) {
            towns[inputTown][inputVenue] = [];
        }

        if (towns[inputTown][inputVenue].indexOf(inputBand) === -1) {
            towns[inputTown][inputVenue].push(inputBand);
        }
    }

    towns = sortAssociativeArray(towns);

    var keys = Object.keys(towns);
    for (var j = 0; j < keys.length; j++) {
        towns[keys[j]] = sortAssociativeArray(towns[keys[j]]);
        var keysVenues = Object.keys(towns[keys[j]]);
        for (var r = 0; r < keysVenues.length; r++) {
            towns[keys[j]][keysVenues[r]].sort();
        }
    }
    console.log(JSON.stringify(towns));

    function sortAssociativeArray(array) {
        var keys = Object.keys(array).sort();
        var sortArr = {};
        for (var i = 0; i < keys.length; i++) {
            sortArr[keys[i]] = array[keys[i]];
        }
        return sortArr;
    }
}

//solve(['ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
//    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
//    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
//    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
//    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
//    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
//    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
//    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
//    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
//    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
//    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
//    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium']);