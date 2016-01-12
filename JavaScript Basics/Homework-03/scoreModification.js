function scoreModification(arr) {
    var result = [];
    for (var i = 0; i < arr.length; i++) {
        var number = Number(arr[i]);
        if (number >= 0 && number <= 400) {
            result.push(number - (number * 0.2))
        }
    }

    console.log(result.sort(compare));
}

function compare(a,b) {
    return a - b;
}

scoreModification([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);