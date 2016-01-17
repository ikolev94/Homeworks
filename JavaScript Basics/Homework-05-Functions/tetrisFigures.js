function solve(input) {
    var figures = {'I': 0, 'L': 0, 'J': 0, 'O': 0, 'Z': 0, 'S': 0, 'T': 0};
    var keys = Object.keys(figures);

    for (var i = 0; i < input.length; i++) {
        for (var j = 0; j < input[i].length; j++) {
            if (input[i][j] == 'o') {
                for (var k = 0; k < keys.length; k++) {
                    checkElem(keys[k], i, j);
                }
            }
        }
    }

    console.log(JSON.stringify(figures));

    function checkElem(elem, row, col) {
        switch (elem) {
            case 'I':
                if (input[row + 3] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row + 1][col] &&
                    input[row][col] == input[row + 2][col] &&
                    input[row][col] == input[row + 3][col]) {
                    figures['I']++;
                }
                break;
            case 'L':
                if (input[row + 2] == undefined || input[row + 2][col + 1] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row + 1][col] &&
                    input[row][col] == input[row + 2][col] &&
                    input[row][col] == input[row + 2][col + 1]) {
                    figures['L']++;
                }
                break;
            case 'J':
                if (input[row + 2] == undefined || input[row + 2][col - 1] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row + 1][col] &&
                    input[row][col] == input[row + 2][col] &&
                    input[row][col] == input[row + 2][col - 1]) {
                    figures['J']++;
                }
                break;
            case 'O':
                if (input[row + 1] == undefined || input[row + 1][col + 1] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row + 1][col] &&
                    input[row][col] == input[row][col + 1] &&
                    input[row][col] == input[row + 1][col + 1]) {
                    figures['O']++;
                }
                break;
            case 'Z':
                if (input[row + 1] == undefined || input[row + 1][col + 2] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row][col + 1] &&
                    input[row][col] == input[row + 1][col + 1] &&
                    input[row][col] == input[row + 1][col + 2]) {
                    figures['Z']++;
                }
                break;
            case 'S':
                if (input[row + 1] == undefined || input[row + 1][col - 2] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row][col - 1] &&
                    input[row][col] == input[row + 1][col - 1] &&
                    input[row][col] == input[row + 1][col - 2]) {
                    figures['S']++;
                }
                break;
            case 'T':
                if (input[row + 1] == undefined || input[row][col + 2] == undefined) {
                    return false;
                }
                if (input[row][col] == input[row][col + 1] &&
                    input[row][col] == input[row + 1][col + 1] &&
                    input[row][col] == input[row][col + 2]) {
                    figures['T']++;
                }
                break;
        }
    }
}

//solve([
//    '--o--o-',
//    '--oo-oo',
//    'ooo-oo-',
//    '-ooooo-',
//    '---oo--'
//]);