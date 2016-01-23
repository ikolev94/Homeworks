function solve(input) {

    var allTeams = {};
    for (var i = 0; i < input.length; i++) {
        var inputArgs = input[i].trim().replace(/\s+/g, ' ').split(/\/|:|-/g);
        var firstTeam = inputArgs[0].trim();
        var secondTeam = inputArgs[1].trim();
        var firstTeamResult = Number(inputArgs[2].trim());
        var secondTeamResult = Number(inputArgs[3].trim());

        updateTeam(firstTeam, secondTeam, firstTeamResult, secondTeamResult);
        updateTeam(secondTeam, firstTeam, secondTeamResult, firstTeamResult);

    }

    function updateTeam(team, opoTeam, scoredGoals, concededGoals) {
        if (!allTeams[team]) {
            allTeams[team] = {
                'goalsScored': 0,
                'goalsConceded': 0,
                'matchesPlayedWith': []
            };
        }

        if (allTeams[team].matchesPlayedWith.indexOf(opoTeam) === -1) {
            allTeams[team].matchesPlayedWith.push(opoTeam);
        }
        allTeams[team].goalsScored += scoredGoals;
        allTeams[team].goalsConceded += concededGoals;
    }
    var sortTeams ={};
    var keys = Object.keys(allTeams).sort();
    for (var j = 0; j < keys.length; j++) {
        var key = keys[j];
        sortTeams[key]=allTeams[key];
        sortTeams[key].matchesPlayedWith.sort();
    }

    console.log(JSON.stringify(sortTeams));
}

//solve([ 'Germany / Argentina: 1-0',
//    'Brazil / Netherlands: 0-3',
//    'Netherlands / Argentina: 0-0',
//    'Brazil / Germany: 1-7',
//    'Argentina / Belgium: 1-0',
//    'Netherlands / Costa Rica: 0-0',
//    'France / Germany: 0-1',
//    'Brazil / Colombia: 2-1' ]);