function solve(input) {
    var matrix = [];
    var degrees = /\d+/g.exec(input[0])[0] % 360;
    input.splice(0, 1);
    var maxWordLength = Math.max.apply(Math, input.map(function (word) {
        return word.length;
    }));
    for (var i = 0; i < input.length; i++) {
        matrix[i] = padRight(input[i], maxWordLength, ' ').split('');
    }
    var col, row, output = '';
    if (degrees === 90) {
        for (col = 0; col < matrix[0].length; col++) {
            for (row = matrix.length - 1; row >= 0; row--) {
                output += matrix[row][col];
            }

            output += '\r\n';
        }
    } else if (degrees === 180) {
        for (row = matrix.length - 1; row >= 0; row--) {
            for (col = matrix[0].length - 1; col >= 0; col--) {
                output += matrix[row][col];
            }
            output += '\r\n';
        }
    } else if (degrees === 270) {
        for (col = matrix[0].length-1; col >=0 ; col--) {
            for (row = 0; row < matrix.length; row++) {
                output += matrix[row][col];
            }

            output += '\r\n';
        }
    } else {
        matrix.forEach(function(line){
            console.log(line.join(''));
        });
        return;
    }
    console.log(output);

    function padRight(value, length, symbol) {
        return (value + new Array(length + 1).join(symbol)).substring(0, length);
    }

    function padLeft(value, length, symbol) {
        return (new Array(length + 1).join(symbol) + value).slice(-length);
    }
}

//solve([ 'Rotate(720)', 'js', 'exam' ]);
//solve(['Rotate(270)', 'hello', 'softuni', 'exam']);
//solve([ 'Rotate(270)', 'hello', 'softuni', 'exam' ]);