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

    function checkElem(elem, row, col) {
        var symbol = 'o';
        switch (elem) {
            case 'I':
                if (symbol == input[row + 1][col] &&
                    symbol == input[row + 2][col] &&
                    symbol == input[row + 3][col]) {
                    figures['I']++;
                }
                break;
            case 'L':
                if (symbol == input[row + 1][col] &&
                    symbol == input[row + 2][col] &&
                    symbol == input[row + 2][col + 1]) {
                    figures['L']++;
                }
                break;
            case 'J':
                if (symbol == input[row + 1][col] &&
                    symbol == input[row + 2][col] &&
                    symbol == input[row + 2][col - 1]) {
                    figures['J']++;
                }
                break;
            case 'O':
                if (symbol == input[row + 1][col] &&
                    symbol == input[row][col + 1] &&
                    symbol == input[row + 1][col + 1]) {
                    figures['O']++;
                }
                break;
            case 'Z':
                if (symbol == input[row][col + 1] &&
                    symbol == input[row + 1][col + 1] &&
                    symbol == input[row + 1][col + 2]) {
                    figures['I']++;
                }
                break;
            case 'S':
                if (symbol == input[row][col - 1] &&
                    symbol == input[row + 1][col - 1] &&
                    symbol == input[row + 1][col - 2]) {
                    figures['I']++;
                }
                break;
            case 'T':
                if (symbol == input[row][col + 1] &&
                    symbol == input[row + 1][col + 1] &&
                    symbol == input[row][col + 2]) {
                    figures['I']++;
                }
                break;
        }
    }
}

solve([
    '--o--o-',
    '--oo-oo',
    'ooo-oo-',
    '-ooooo-',
    '---oo--'
]);