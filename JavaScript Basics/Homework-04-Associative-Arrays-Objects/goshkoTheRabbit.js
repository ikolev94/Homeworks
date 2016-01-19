function solve(input) {
    var directions = input[0].split(', '),
        vegetables = {'&': 0, '*': 0, '#': 0, '!': 0},
        visitedCells = [],
        matrix = [],
        i = 0,
        hattedWalls = 0,
        currentRow = 0,
        currentCol = 0;

    for (i = 1; i < input.length; i++) {
        matrix[i - 1] = input[i].split(', ');
    }

    for (i = 0; i < directions.length; i++) {
        switch (directions[i]) {
            case "down":
                currentRow++;
                if (currentRow >= matrix.length) {
                    currentRow = matrix.length - 1;
                    hattedWalls++;
                    continue;
                }
                break;
            case "up":
                currentRow--;
                if (currentRow < 0) {
                    currentRow = 0;
                    hattedWalls++;
                    continue;
                }
                break;
            case "left":
                currentCol--;
                if (currentCol < 0) {
                    currentCol = 0;
                    hattedWalls++;
                    continue;
                }
                break;
            case "right":
                currentCol++;
                if (currentCol >= matrix[currentRow].length) {
                    currentCol = matrix[currentRow].length - 1;
                    hattedWalls++;
                    continue;
                }
                break;
        }
        eat(Object.keys(vegetables), currentRow, currentCol);
        visitedCells.push(matrix[currentRow][currentCol]);


    }

    function eat(foods, row, col) {
        for (var j = 0; j < foods.length; j++) {
            var food = foods[j];
            var foodOutput = '{' + food + '}';
            if (matrix[row][col].indexOf(foodOutput) !== -1) {
                vegetables[food]++;
                matrix[row][col] = matrix[row][col].replace(foodOutput, '@');
            }
        }
    }

    console.log('{' + '"&":' + vegetables['&'] + ',"*":' + vegetables['*'] + ',"#":' + vegetables['#']
        + ',"!":' + vegetables['!'] + ',"wall hits":' + hattedWalls + '}');
    console.log(visitedCells.length == 0 ? 'no' : visitedCells.join('|'));
}

//solve(['up, right, left, down', 'as{!}xnk']);

//solve(['right, up, up, down',
//    'asdf, as{#}aj{g}dasd, kjldk{}fdffd, jdflk{#}jdfj',
//    'tr{X}yrty, zxx{*}zxc, mncvnvcn, popipoip',
//    'poiopipo, nmf{X}d{X}ei, mzoijwq, omcxzne']);