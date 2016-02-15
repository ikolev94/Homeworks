function add(a) {
    "use strict";
    var toAdd = a;

    function f(b) {
        toAdd += b;
        return f;
    }

    f.toString = function () {
        return toAdd;
    };
    return f;
}

var addTwo = add(2);
console.log(addTwo.toString());
console.log(addTwo(3).toString());
console.log(addTwo(3)(5).toString());

console.log(add(2)(3).toString());
//console.log(add(2)(3));