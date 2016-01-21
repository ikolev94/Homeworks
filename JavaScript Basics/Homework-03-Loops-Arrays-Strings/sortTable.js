function solve(input) {
    var lines = [];
    console.log('<table>\r\n<tr><th>Product</th><th>Price</th><th>Votes</th></tr>');
    input.splice(0, 2);
    input.pop();

    input.forEach(function (line) {
        var price = />(\d+\.?\d*)/g.exec(line)[1];
        var info = line.split('<td>')[1];
        lines.push({
            'info': info,
            'price': price,
            'output': line
        });
    });
    lines.sort(function (a, b) {
        if (a.price !== b.price) {
            return a.price - b.price;
        }
        return a.info.localeCompare(b.info);
    });

    lines.forEach(function (e) {
        console.log(e.output);
    });

    console.log('</table>');
}

//solve(['<table>',
//    '<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
//    '<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>',
//    '<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
//    '<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
//    '<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
//    '<tr><td>Cofee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
//    '</table>']);