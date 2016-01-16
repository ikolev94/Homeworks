function solve(args) {
    var start = Number(args[0]);
    var end = Number(args[1]);

    var fibonacci = [0, 1];
    var first = fibonacci[0],
        second = fibonacci[1],
        current = first + second;

    while (current <= end) {
        fibonacci.push(current);
        first = second;
        second = current;
        current = first + second;
    }

    console.log('<table>');
    console.log('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');

    for (var i = start; i <= end; i++) {
        var contains = fibonacci.indexOf(i) > -1;
        console.log('<tr>' +
            '<td>' + i + '</td>' +
            '<td>' + i * i + '</td>' +
            '<td>' + (contains ? 'yes' : 'no') + '</td>' +
            '</tr>')
    }

    console.log('</table>');
}