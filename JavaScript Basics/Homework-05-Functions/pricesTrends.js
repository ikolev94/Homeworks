function pricesTrends(input) {
    var numbers = [];
    input.forEach(function (el) {
        numbers.push(Number(Number(el).toFixed(2)));
    });
    console.log('<table>\r\n<tr><th>Price</th><th>Trend</th></tr>');
    console.log('<tr><td>' + numbers[0].toFixed(2) + '</td><td><img src="fixed.png"/></td></td>');
    for (var i = 1; i < numbers.length; i++) {
        var currentNum = numbers[i];
        var previousNum = numbers[i - 1];
        var photo = 'fixed';
        if (currentNum < previousNum) {
            photo = 'down';
        } else if (currentNum > previousNum) {
            photo = 'up';
        }
        console.log('<tr><td>' + numbers[i].toFixed(2) + '</td><td><img src=\"' + photo + '.png\"/></td></td>');
    }

    console.log('</table>')
}

//pricesTrends(['36.333',
//    '36.5',
//    '37.019',
//    '35.4',
//    '35',
//    '35.001',
//    '36.225'
//]);