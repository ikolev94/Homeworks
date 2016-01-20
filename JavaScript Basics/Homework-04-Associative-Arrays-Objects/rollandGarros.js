function solve(input) {
    var players = [];
    for (var i = 0; i < input.length; i++) {
        var lineArgs = input[i].trim().replace(/\s+/g, ' ').split(/vs\.|:/g);
        var player1 = lineArgs[0].trim();
        var player2 = lineArgs[1].trim();
        var results = lineArgs[2].trim().split(' ');

        var gamesWon1 = 0, gamesWon2 = 0, gamesLost1 = 0, gamesLost2 = 0, setWon1 = 0, setWon2 = 0, setLost1 = 0,
            setLost2 = 0, matchesWon1 = 0, matchesWon2 = 0, matchesLost1 = 0, matchesLost2 = 0;
        totalPointsPlayer1 = 0;
        var totalPointsPlayer2 = 0;
        for (var j = 0; j < results.length; j++) {
            var result = results[j].split('-');
            var player1Result = Number(result[0]);
            var player2Result = Number(result[1]);
            gamesWon1 += player1Result;
            gamesLost1 += player2Result;
            gamesWon2 += player2Result;
            gamesLost2 += player1Result;

            if (player1Result > player2Result) {
                setWon1++;
                setLost2++;
                totalPointsPlayer1++;
            } else {
                setWon2++;
                setLost1++;
                totalPointsPlayer2++;
            }
        }

        if (totalPointsPlayer1 > totalPointsPlayer2) {
            matchesWon1++;
            matchesLost2++;
        } else {
            matchesWon2++;
            matchesLost1++;
        }

        updatePlayer(player1,matchesWon1,matchesLost1,setWon1,setLost1,gamesWon1,gamesLost1);
        updatePlayer(player2,matchesWon2,matchesLost2,setWon2,setLost2,gamesWon2,gamesLost2);

        function updatePlayer(name, matchesWon, matchesLost, setsWon, setsLost, gamesWon, gamesLost) {
            var player = players.filter(function (p) {
                return p.name === name;
            })[0];

            if (!player) {
                players.push(
                    {
                        name: name,
                        matchesWon: matchesWon,
                        matchesLost: matchesLost,
                        setsWon: setsWon,
                        setsLost: setsLost,
                        gamesWon: gamesWon,
                        gamesLost: gamesLost
                    });
            } else {
                player.matchesWon += matchesWon;
                player.matchesLost += matchesLost;
                player.setsWon += setsWon;
                player.setsLost += setsLost;
                player.gamesWon += gamesWon;
                player.gamesLost += gamesLost;
            }
        }
    }

    players.sort(function (firstPlayer, secondPlayer) {
        if (secondPlayer.matchesWon !== firstPlayer.matchesWon) {
            return secondPlayer.matchesWon - firstPlayer.matchesWon;
        }

        if (secondPlayer.setsWon !== firstPlayer.setsWon) {
            return secondPlayer.setsWon - firstPlayer.setsWon;
        }

        if (secondPlayer.gamesWon !== firstPlayer.gamesWon) {
            return secondPlayer.gamesWon - firstPlayer.gamesWon;
        }

        return firstPlayer.name.localeCompare(secondPlayer.name);
    });

    console.log(JSON.stringify(players));

}

//solve(['Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
//    'Andy Murray vs. David Ferrer : 6-4 7-6']);

//solve(['Novak Djokovic vs. Roger Federer : 6-3 6-3',
//    'Roger    Federer    vs.        Novak Djokovic    :         6-2 6-3',
//    'Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
//    'Andy Murray vs. David Ferrer : 6-4 7-6',
//    'Tomas Bedrych vs. Kei Nishikori : 4-6 6-4 6-3 4-6 5-7',
//    'Grigor Dimitrov vs. Milos Raonic : 6-3 4-6 7-6 6-2',
//    'Pete Sampras vs. Andre Agassi : 2-1',
//    'Boris Beckervs.Andre        \t\t\tAgassi:2-1']);