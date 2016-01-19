function solve(input) {
    var numberOfJumps = Number(input[0]);
    var fieldSize = Number(input[1]);
    var allPlayers = [];
    var winnerIndex = -1;
    for (var i = 2; i < input.length; i++) {
        var playerArgs = input[i].split(', ');
        playerArgs[1] = Number(playerArgs[1]);
        playerArgs.push(0);
        allPlayers.push(playerArgs);
    }

    (function () {
        for (var j = 0; j < numberOfJumps; j++) {
            for (var k = 0; k < allPlayers.length; k++) {
                var player = allPlayers[k];
                player[2] += player[1];

                if (player[2] >= fieldSize - 1) {
                    player[2] = fieldSize - 1;
                    winnerIndex = k;
                    return;
                }
            }
        }
    }());

    console.log(new Array(fieldSize + 1).join('#'));
    console.log(new Array(fieldSize + 1).join('#'));

    for (var i = 0; i < allPlayers.length; i++) {
        var currentPlayer = allPlayers[i];
        var output = '';
        output += new Array(currentPlayer[2] + 1).join('.');
        output += currentPlayer[0][0].toUpperCase();
        output += new Array(fieldSize - currentPlayer[2]).join('.');
        console.log(output);
    }

    console.log(new Array(fieldSize + 1).join('#'));
    console.log(new Array(fieldSize + 1).join('#'));

    if (winnerIndex != -1) {
        console.log('Winner: ' + allPlayers[winnerIndex][0]);
    } else {
        //var max = Math.max.apply(Math, allPlayers.map(function (o) {
        //    return o[2]
        //}));
        console.log('Winner: ' + allPlayers.filter(function (p) {
                return p[2] == Math.max.apply(Math, allPlayers.map(function (o) {
                        return o[2]
                    }));
            }).pop()[0]);
    }

}
//solve(['10', '19', 'angel, 9', 'Boris, 10', 'Georgi, 3', 'Dimitar, 7']);
//solve(['3', '5', 'cura, 1', 'Pepi, 1', 'UlTraFlee, 1', 'BOIKO, 1']);