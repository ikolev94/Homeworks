function revealTriangles(input) {
    var output = [];
    for (var row = 0; row < input.length; row++) {
        output[row] = input.split('');
    }
    console.log(output)
}

var arr = [];
require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
}).on('line', function (line) {
    arr.push(line);
}).on('close', function () {
    revealTriangles(arr);
});
