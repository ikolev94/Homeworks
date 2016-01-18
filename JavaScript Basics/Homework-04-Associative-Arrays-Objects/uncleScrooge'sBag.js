function solve(input) {
    var total = 0;
    input.forEach(function (element) {
        var elementArgs = element.split(' ');

        if ('coin' == elementArgs[0].toLowerCase()) {
            if (elementArgs[1] % 1 == 0 && elementArgs[1] > 0) {
                total += Number(elementArgs[1]);
            }
        }
    });

    console.log('gold : ' + Math.floor(total / 100));
    console.log('silver : ' + Math.floor((total % 100) / 10));
    console.log('bronze : ' + Math.floor(total % 10));
}

//solve(['coin 1', 'coin 2', 'coin 5', 'coin 10', 'coin 20', 'coin 50', 'coin 100', 'coin 200', 'coin 500', 'cigars 1']);