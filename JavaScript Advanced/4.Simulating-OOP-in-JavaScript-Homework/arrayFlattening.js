Array.prototype.flatten = function () {
    "use strict";
    var result = [];

    function flatt(arr) {
        arr.forEach(function (e) {
            if (Array.isArray(e)) {
                flatt(e);
            } else {
                result.push(e);
            }
        });
    }
    flatt(this);

    return result;
};

//var array = [1, 2, 3, 4];
//console.log(array.flatten());
//var array = [1, 2, [3, 4], [5, 6]];
//console.log(array.flatten());
//console.log(array); // Not changed
var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());