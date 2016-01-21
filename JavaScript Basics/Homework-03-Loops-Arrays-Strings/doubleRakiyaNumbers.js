function solve(input) {
    console.log('<ul>');
    for (var i = Number(input[0]); i <= Number(input[1]); i++) {
        if (i.toString().match(/(\d{2})\d*\1/g)) {
            console.log('<li><span class=\'rakiya\'>' + i + '</span>' + '<a href="view.php?id=' + i + '>View</a></li>');
        } else {
            console.log('<li><span class=\'num\'>' + i + '</span></li>');
        }
    }
    console.log('</ul>');
}

//solve(['5', '8']);
//solve(['11210', '11215']);
//solve(['55555', '55560']);