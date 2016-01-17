function solve(input) {
    var maxSum;
    var output = '';
    for (var i = 2; i < input.length - 1; i++) {
        var line = input[i];
        var reg = new RegExp(/[\d.-]+/g);
        var numbers = [];
        var sum = 0;
        var result;
        while ((result = reg.exec(line)) !== null) {
            var number = Number(result[0]);
            if (!isNaN(number)) {
                sum += number;
                numbers.push(result[0]);
            }
        }
        if (maxSum == undefined || sum > maxSum) {
            maxSum = sum;
            output = sum + ' = ' + numbers.join(' + ');
        }
    }
    if (output.length == 0||output=='0 = ') {
        console.log('no data');
    } else {
        console.log(output);
    }
}

//solve([
//    '<table>',
//    '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
//    '<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
//    '<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
//    '<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>',
//    '<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
//    '</table>'
//]);

//solve([
//    '<table>',
//    '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
//    '<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
//    '</table>'
//]);