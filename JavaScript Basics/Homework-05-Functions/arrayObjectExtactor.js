function extractObjects(array) {

    var result = [];
    array.forEach(function (element) {
        if (Object.prototype.toString.call(element) === '[object Object]' && element!==null) {
            result.push(element);
        }
    });
    console.log(result);


}

var arr = [
    "Pesho",
    4,
    4.21,
    {name: 'Valyo', age: 16},
    {type: 'fish', model: 'zlatna ribka'},
    [1, 2, 3],
    "Gosho",
    {name: 'Penka', height: 1.65}
];

extractObjects(arr);