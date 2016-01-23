function revealTriangles(input) {
    var output = [],
        matrix = [];

    for (var i = 0; i < input.length; i++) {
        output[i] = input[i].split('');
        matrix[i] = input[i].split('');
    }

    for (var row = 0; row < matrix.length; row++) {
        for (var col = 0; col < matrix[row].length; col++) {
            if (!matrix[row + 1] || !matrix[row + 1][col + 1] || !matrix[row + 1][col - 1]) {
                continue;
            }
            if (matrix[row][col] === matrix[row + 1][col]
                && matrix[row][col] === matrix[row + 1][col + 1]
                && matrix[row][col] === matrix[row + 1][col - 1]) {
                output[row][col] = '*';
                output[row + 1][col] = '*';
                output[row + 1][col + 1] = '*';
                output[row + 1][col - 1] = '*';
            }
        }
    }
    for (var j = 0; j < output.length; j++) {
        console.log(output[j].join(''));
    }
}

//revealTriangles([ 'dffdsgyefg',
//    'ffffeyeee',
//    'jbfffays',
//    'dagfffdsss',
//    'dfdfa',
//    'dadaaadddf',
//    'sdaaaaa',
//    'daaaaaaasf' ]);
//revealTriangles(
//    [
//        'abcdexgh',
//        'bbbdxxxh',
//        'abcxxxxx'
//    ]);
//revealTriangles([ 'aa', 'aaa', 'aaaa', 'aaaaa' ]);